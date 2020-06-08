txt = str("Aa")
shift = 5
result = ""
for i in range(len(txt)):
    ch = txt[i]
    if ch.isupper():
        ch = chr(ord(ch) + shift)
        if ord(ch) > ord("Z"):
            ch = chr(ord(ch) + ord("A") - ord("Z") - 1)
        result = result + ch
    elif ch.islower():
        ch = chr(ord(ch) + shift)
        if ord(ch) > ord("z"):
            ch = chr(ord(ch) + ord("a") - ord("z") - 1)
        result = result + ch
    else:
        result = result + ch
print(result)