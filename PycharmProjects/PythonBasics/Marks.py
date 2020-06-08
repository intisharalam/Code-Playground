sum = 0
print("Enter Marks:")
for i in range(5):
    marks = int(input())
    sum = sum + marks
print("Total Marks: " + str(sum))
print("Average marks: " + str(sum/5))