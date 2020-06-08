print("Enter A Number:")
num = int(input())
i, counter = 1, 0
while i != num:
    mod = num % i
    if mod == 0:
        counter = counter + 1
    i = i + 1
if counter == 1:
    print("Prime Number")
else:
    print("Not Prime")