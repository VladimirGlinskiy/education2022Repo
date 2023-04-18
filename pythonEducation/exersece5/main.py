import numpy as np
from pythonEducation.exersece5.exersice5 import set_players_name_input
from pythonEducation.exersece5.exersice5 import roll_the_dice

players = set_players_name_input()
results = []

sets = int(input("Введите количество бросков: "))

for i in range(len(players)):
    results.append(0)

for i in range(sets):
    print("Бросок", i + 1)
    max_value = 0
    max_values_index = []

    for iterator in range(0, len(players)):
        results[iterator] = roll_the_dice(players[iterator])

    for i in range(0, len(results)):
        if results[i] > max_value:
            max_value = results[i]
            max_values_index = [i]
        elif results[i] == max_value:
            max_values_index.append(i)
            max_value = results[i]
    print("Наибольшее значене броска: ", max_value)
    print("Игрок, выигравший в этом ходу: ", players[max_values_index[0]].name)

    if len(max_values_index) == 1:
        players[max_values_index[0]].addWinRate()
    elif len(max_values_index) > 1:
        print("Ничья. Очки не засчитываются никому")

rating = []
for i in range(len(players)):
    rating.append(players[i].winrate)
rt = np.array(rating)

print(rating)

winners = []
for player in players:
    if player.winrate == rt.max():
        winners.append(player.name)

if len(winners) == 1:
    print('Победитель', winners[0])
else:
    print("Ничья. Имена игроков, набравших максимальный результат: ", winners)

