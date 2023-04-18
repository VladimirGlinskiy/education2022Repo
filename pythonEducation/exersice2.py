string1 = " This is a string. "
string2 = " this is another string. "

print("Результат сложения 2х строк: ", string1 + string2)

print('Длина строки \'' + string1 + '\'' + ': ', len(string1))
print('Нижний регистр: ' + '\'' + string2.lower() + '\'')
print('Заглавные буквы: ' + '\'' + string2.title() + '\'')
print('Верхнй регистр: ' + '\'' + string1.upper() + '\'')
print('Удалитиь пробелы в конце строки: ' + '\'' + string1.rstrip() + '\'')
print('Удалитиь пробелы в начале строки: ' + '\'' + string1.lstrip() + '\'')
print('Удалить пробелы с обоих концов: ' + '\'' + string1.strip() + '\'')
print('strip("0"): ' + string2.strip('T, g.'))


d = "qwerty"
ch = d[1:5:2]
print(ch)

x = 3
y = 5

print('Деление 3/5: ', x/y)
print('Взятие остатка 3%5: ', x%y)
print('Возведение в степень 3**5: ', x**y)


concat = "string" + str(15)
print("Результат конкатенации")
print(concat)

n1 = input("Введите первое число: ")
n2 = input("Введите второе число: ")
n3 = float(n1) + float(n2)
print(n1 + " plus " + n2 + " = ", "{:5.2f}".format(n3))


a = 1 / 3
print("{:7.3f}".format(a))

a = 2 / 3
b = 2 / 9
print("{:7.3f} {:7.3f}".format(a, b))
print("{:10.3e} {:10.3e}".format(a, b))

list1 = [82, 8, 23, 97, 92, 44, 17, 39, 11, 12]
print(list1)
help(list1.remove)
list1[0] = 76
list1.append(1)
list1.insert(2, 2)
list1.pop(4)
list1.pop(len(list1) - 1)
print(list1)


list1.sort(reverse=True)
print(list1)
list2 = [3, 5, 6, 2, 33, 6, 11]
lis = sorted(list2)
print(lis)

print(dir(tuple))
help(tuple.index)
seq = (2, 8, 23, 97, 92, 44, 17, 39, 11, 12)
print(seq.count(8))
print(seq.index(44))
list_seq = list(seq)
print(type(list_seq))
list_seq.sort()
list_seq.append(77)
print(list_seq)

D = {"food": "Apple", "quantity": 4, "color": "Red"}
print(D["food"])
D["quantity"] += 10
print(D["quantity"])

print("Введите имя и возраст")
dp = {"name": input(), "age": input()}
print(dp)

rec = {"name": {"firstname": "Bob", "lastname": "Smith"},
       "job": ["dev", "mgr"],
       "age": 25}
print(rec["name"])
print(rec["name"]["firstname"])
print(rec["job"])
rec["job"].append("janitor")
print(rec)
