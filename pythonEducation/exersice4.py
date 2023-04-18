from random import randint
import time

total_score_1 = 0
total_score_2 = 0

player_1: str = input('Введите имя 1-го играющего ')
player_2: str = input('Введите имя 2-го играющего ')
number_of_games: str = input("Введиите количество партий: ")


for i in range(int(number_of_games)):

    print('Игра', i+1)

    print('Кубик бросает', player_1)
    time.sleep(2)
    n1 = randint(1, 6)
    print('Выпало:', n1)

    print('Кубик бросает', player_2)
    time.sleep(2)
    n2 = randint(1, 6)
    print('Выпало:', n2)

    if n1 > n2:
        total_score_1 += 1
    else:
        total_score_2 += 1

print("Количество побед", player_1, ": ", total_score_1)
print("Количество побед", player_2, ": ", total_score_2)

if total_score_1 > total_score_2:
    print("Победа ", player_1)
elif total_score_1 < total_score_2:
    print("Победа ", player_2)
else:
    print("Ничья")