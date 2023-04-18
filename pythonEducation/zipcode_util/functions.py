from pythonEducation.zipcode_util import zip_util
from geopy.distance import geodesic

zip_codes = zip_util.read_zip_all()


def write_loc():
    zip_code = input("Enter a ZIP Code to lookup => ")
    result_of_search = find_loc(zip_code)

    if isinstance(result_of_search, tuple):

        print("ZIP Code", zip_code, "is in", ", ".join(result_of_search[1]), 'country', "\ncoordinates: (",
              deg_to_dms(result_of_search[0][0], 'latitude'),', ',
              deg_to_dms(result_of_search[0][1], 'longitude'), ')')

        return
    else:
        print(find_loc(zip_code))

def find_loc(zip_code):
    flag = False
    for i in range(0, len(zip_codes)):
        if zip_code == zip_codes[i][0]:
            flag = True
            zip_code_location = zip_codes[i][1:3]
            loc_name = zip_codes[i][3:6]
            return zip_code_location, loc_name
    if not flag:
        return "Invalid or unknown ZIP Code"


def zip():
    flag = False
    city_name = input("Enter a city name to lookup => ").title()
    state_name = input("Enter the state name to lookup => ").upper()
    city_name_zips = []
    for i in range(len(zip_codes) - 1):
        if city_name == zip_codes[i][3] and state_name == zip_codes[i][4]:
            flag = True
            city_name_zips.append(zip_codes[i][0])

    if flag:
        print("The following ZIP Code(s) found for", city_name + ',', state_name + ":", ", ".join(city_name_zips))
    else:
        print("No ZIP Code found for", city_name+',', state_name)


def dist():
    zip_code_1 = input("Enter the first ZIP Code => ")
    zip_code_2 = input("Enter the second ZIP Code => ")
    if isinstance(find_loc(zip_code_1), tuple) & isinstance(find_loc(zip_code_2), tuple):
        coordinate_zip_code_1 = find_loc(zip_code_1)[0]
        coordinate_zip_code_2 = find_loc(zip_code_2)[0]
        distance_miles = round(geodesic(coordinate_zip_code_1, coordinate_zip_code_2).miles, 2)
        print("The distance between", zip_code_1, "and", zip_code_2, "is", distance_miles, "miles")
        return
    else:
        print("The distance between", zip_code_1, "and", zip_code_2, "cannot be determined")

def deg_to_dms(deg, pretty_print, ndp=2):
    m, s = divmod(abs(deg) * 3600, 60)
    d, m = divmod(m, 60)
    if deg < 0:
        d = -d
    d, m = int(d), int(m)

    if pretty_print:
        if pretty_print == 'latitude':
            hemi = 'N' if d >= 0 else 'S'
        elif pretty_print == 'longitude':
            hemi = 'E' if d >= 0 else 'W'
        else:
            hemi = '?'
        return '{d:d}° {m:d}′ {s:.{ndp:d}f}″ {hemi:1s}'.format(
            d=abs(d), m=m, s=s, hemi=hemi, ndp=ndp)
    return d, m, s