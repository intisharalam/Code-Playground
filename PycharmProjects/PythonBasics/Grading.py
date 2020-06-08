total = 0
average = 0
print("Enter Marks:")
for i in range(5):
    marks = int(input())
    total = total + marks
print("Total Marks: " + str(total))
average = total / 5
print("Average marks: " + str(average))
if average >= 90:
    print("Grade: A*")
elif average >= 80:
    print("Grade: A")
elif average >= 70:
    print("Grade: B")
elif average >= 60:
    print("Grade: C")
elif average >= 50:
    print("Grade D")
else:
    print("Failed Miserably")
