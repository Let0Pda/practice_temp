'''
# Показать числа, у которых
 последняя цифра делится на 4

'''


n = int(input("n = "))
for index in range(n + 1):
    if (index % 10) % 4 == 0: # (index % 10) - деление числа на 10 ЭТО ПОСЛЕДНЯЯ цифра числа,
        print(index, end=" ")
