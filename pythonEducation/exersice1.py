import math

YARD_TO_MILE_RATIO = 1 / 1760
FOOT_TO_MILE = 1 / 5280

# d1
distance_to_water_edge = float(input("Введите кратчайшее расстояние от спасателя до кромки воды (в ярдах)")) * YARD_TO_MILE_RATIO

# d2
distance_between_water_edge_and_swimmer = float(
    input("Кратчайшее расстояние от утопающего до берега (в футах): ")) * FOOT_TO_MILE

# h
delta = float(input("Введите боковое смещение между спасателем и утопающим (в ярдах): ")) * YARD_TO_MILE_RATIO

# V
speed_on_sand = float(input("Введите скорость движения спасателя по песку (в милях в час): "))

# n
stopping_factor_in_water = float(input("Введите коэффициент замедления спасателя при движении в воде: "))

# ⍬
angle_of_inclination_of_the_trajectory = float(input("Введите направление движения спасателя по песку (В градусах)"))

distance_l1 = distance_to_water_edge / math.cos(math.radians(angle_of_inclination_of_the_trajectory))
distance_x1 = distance_l1 * math.sin(math.radians(angle_of_inclination_of_the_trajectory))
distance_x2 = delta - distance_x1
distance_l2 = math.sqrt(pow(distance_between_water_edge_and_swimmer, 2) + pow(distance_x2, 2))
time = ((distance_l1 + stopping_factor_in_water * distance_l2) / speed_on_sand) * 3600

print("Время в секундах")
print(time)
