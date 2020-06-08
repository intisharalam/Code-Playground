import cmath
print("Enter a:")
a = int(input())
print("Enter b:")
b = int(input())
print("Enter c:")
c = int(input())
x = (-b + cmath.sqrt((b*b)-(4*a*c)))/(2*a)
print("Result: " + str(x))
