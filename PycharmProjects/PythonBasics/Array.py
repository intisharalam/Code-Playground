array1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
array2 = [11, 12, 13, 14, 15, 16, 17, 18, 19, 20]
array3 = []
for i in range(len(array1)):
    array3.append(int(array1[i]) + int(array2[i]))
print(str(array3))
