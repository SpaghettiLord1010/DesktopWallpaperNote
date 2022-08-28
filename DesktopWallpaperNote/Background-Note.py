import sys
import numpy
import numpy as np
from PIL import Image
from PIL import ImageDraw
from PIL import ImageFont
import ctypes
import re

img_path = sys.argv[1]
gc1_r = sys.argv[2]
gc1_g = sys.argv[3]
gc1_b = sys.argv[4]
gradient_color1 = str(gc1_r) + "," + str(gc1_g) + "," + str(gc1_b)
gc2_r = sys.argv[5]
gc2_g = sys.argv[6]
gc2_b = sys.argv[7]
gradient_color2 = str(gc2_r) + "," + str(gc2_g) + "," + str(gc2_b)
txt_r = sys.argv[8]
txt_g = sys.argv[9]
txt_b = sys.argv[10]
txtcolor = str(txt_r) + "," + str(txt_g) + "," + str(txt_b)
img_text = sys.argv[11]
font_size = sys.argv[12]

cleaned_filepath = img_path + "/" + re.sub('\W+','', img_text) + ".png"
multi_line_string = img_text.replace("°", "\n")

print("Output-Path: " + cleaned_filepath + "\nGradient-Color 1: " + gradient_color1 + "\nGradien-Color 2: " + gradient_color2 + "\nImage Text: " + img_text + "\nText Color: " + txtcolor)

def get_gradient_2d(start, stop, width, height, is_horizontal):
    if is_horizontal:
        return np.tile(numpy.linspace(start, stop, width), (height, 1))
    else:
        return np.tile(numpy.linspace(start, stop, height), (width, 1)).T

def get_gradient_3d(width, height, start_list, stop_list, is_horizontal_list):
    result = numpy.zeros((height, width, len(start_list)), dtype=float)

    for i, (start, stop, is_horizontal) in enumerate(zip(start_list, stop_list, is_horizontal_list)):
        result[:, :, i] = get_gradient_2d(start, stop, width, height, is_horizontal)

    return result

def get_text_dimensions(text_string, font):
    ascent, descent = font.getmetrics()

    text_width = font.getmask(text_string).getbbox()[2]
    text_height = font.getmask(text_string).getbbox()[3] + descent

    return (text_width, text_height)


array = get_gradient_3d(1920, 1080, (int(gc1_r), int(gc1_g), int(gc1_b)), (int(gc2_r), int(gc2_g), int(gc2_b)), (True, True, True))
Image.fromarray(numpy.uint8(array)).save(cleaned_filepath, quality=100)

my_image = Image.open(cleaned_filepath)
I1 = ImageDraw.Draw(my_image)
my_font = ImageFont.truetype('arial.ttf', int(font_size))
my_text_height = get_text_dimensions(multi_line_string, my_font)[1]

v_pos = (1080/2) - (int(my_text_height))

I1.text((30, v_pos), multi_line_string, fill=(int(txt_r), int(txt_g), int(txt_b)), font=my_font)
my_image.save(cleaned_filepath)

ctypes.windll.user32.SystemParametersInfoW(20, 0, cleaned_filepath , 0)
