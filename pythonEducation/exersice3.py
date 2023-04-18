import random
from statistics import median, mean, stdev

list_of_integers = []
for i in range(10):
	list_of_integers.append(random.randint(0, 100))
print('List of integers:', list_of_integers)


print('Sum:', sum(list_of_integers))
print('Average:', mean(list_of_integers))
print('Median:', median(list_of_integers))
print('Standard deviation:', stdev(list_of_integers))