from random import randint
import time


class player:
    winrate = 0

    def __init__(self, name):
        self.name = name

    def addWinRate(self):
        self.winrate +=1


def set_players_name_input():
    players = []
    char = 'Y'

    while char == 'Y':
        player_name = input("Type player name: ")
        players.append(player(player_name))
        char = input("If you want to add one more player please type \'Y\' ")
    return players


def roll_the_dice(player):
    print('Кубик бросает', player.name)
    time.sleep(0.5)
    dice = randint(1, 6)
    print('Выпало:', dice)
    return dice
