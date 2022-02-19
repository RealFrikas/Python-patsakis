import random  #Hi patsakis
allsteps = 0
print ("duh")
for i in range(100):      #start of 100 games
    board = [[0,0,0],[0,0,0],[0,0,0]]
    print ("game " +str(i) +" has started")
    win = False
    while win == False:   #start of a single game
        pos = False
        while pos == False:
            x = random.randrange(0,3)
            y = random.randrange(0,3)
            size = random.randrange(1,4)
            if board[x][y] < size:   #checks for valid space
                print ("vazo kapaki stin thesi " +str(x+1) +" " +str(y+1) +" size " +str(size))
                pos = True
                board[x][y] = size
                allsteps = allsteps + 1 
            for j in range(0,3):
                if board[j][0] < board[j][1] < board[j][2] and board[j][0] != 0:   #checks for triliza 
                    win=True
                if board[0][j] < board[1][j] < board[2][j] and board[0][j] != 0:
                    win=True
                if board[j][0] > board[j][1] > board[j][2] and board[j][2] != 0: 
                    win=True
                if board[0][j] > board[1][j] > board[2][j] and board[2][j] != 0:  
                    win=True
                if board[j][0] == board[j][1] == board[j][2] and board[j][0] != 0: 
                    win=True
                if board[0][j] == board[1][j] == board[2][j] and board[0][j] != 0: 
                    win=True
                if board[j][0] == board[j][1] == board[j][2] and board[j][2] != 0:   
                    win=True
                if board[0][j] == board[1][j] == board[2][j] and board[2][j] != 0: 
                    win=True
            if board[0][0] == board[1][1] == board[2][2] and board[0][0] != 0:
                win=True
            if board[0][2] == board[1][1] == board[2][0] and board[2][0] != 0: 
                win=True
            if board[0][0] < board[1][1] < board[2][2] and board[0][0] != 0:
                win=True
            if board[0][2] < board[1][1] < board[2][0] and board[0][2] != 0:
                win=True
            if board[0][0] > board[1][1] > board[2][2] and board[2][2] != 0: 
                win=True
            if board[0][2] > board[1][1] > board[2][0] and board[2][0] != 0:
                win=True
    print ("game end")
mo = allsteps/100
print ("average is " +str(mo))
