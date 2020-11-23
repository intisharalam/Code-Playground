board = [
    [6,0,0,3,9,0,0,0,0],
    [0,0,0,0,0,4,0,2,0],
    [0,7,0,0,5,0,0,6,8],
    [9,0,5,0,0,8,3,0,0],
    [0,0,0,7,2,5,1,4,0],
    [1,4,0,0,0,0,0,0,0],
    [0,0,1,6,0,0,4,0,0],
    [0,0,8,0,0,0,2,0,7],
    [0,5,3,4,0,9,0,0,0]
]


# The Main Function which literally solves this damn thing!!!
def Solve(board):
    
    # Looks for empty slots
    Find = Search_Void(board)
    if not Find:
        # If not empty returns true for the recursion below
        return True
    else:
        # If empty returns the coordinates
        row, column = Find

    for i in range(1,10):
        # If the number is valid in that position, it is stored there
        if Number_Position_Valid(board, i, (row, column)):
            board[row][column] = i

            # Recursion-- checks if the i value is valid in that position
            if Solve(board):
                return True
            
            # Sets it to 0 if none of the i values came valid
            board[row][column] = 0
    return False


# Prints visual representation of the board in 2D(obviously ;p) --Optional--
def Visualise_Board(board):

    for i in range(len(board)):
        if i % 3 == 0 and i != 0:
            print("- - - - - - - -")

        for j in range(len(board[0])):
            if j % 3 == 0 and j != 0:
                print(" | ", end = "")

            if j == 8:
                print(board[i][j])
            else:
                print(str(board[i][j]) + " ", end = "")

Visualise_Board(board)


# Checks if number is valid in that position
def Number_Position_Valid(board, number, position):
    # Checks rows for same number(else invalid number)
    for i in range(len(board[0])):
        if board[position[0]][i] == number and position[1] != i:
            return False

    # Checks columns for same number(else invalid number)
    for i in range(len(board[0])):
        if board[i][position[1]] == number and position[0] != i:
            return False

    # Checks around the square in which number is in.(Remeber the grid? If not use the Visualise_Board function)
    Box_x = position[1] // 3
    # Il positione nel X/Y axis **Italian accent**
    Box_y = position[0] // 3

    for i in range(Box_y*3, Box_y*3 + 3):
        for j in range(Box_x*3, Box_x*3 + 3):
            if board[i][j] == number and (i, j) != position:
                return False
    
    return True



# Searches for empty/0 slots in the table
def Search_Void(board):

    for i in range(len(board)):
        for j in range(len(board[0])):
            if board[i][j] == 0:
                return (i,j) # !!!Row & Column!!! Dont forget this damn thing!!!
    return None


Visualise_Board(board)
print(" \n \n ")
Solve(board)
print(" \n \n ")
Visualise_Board(board)