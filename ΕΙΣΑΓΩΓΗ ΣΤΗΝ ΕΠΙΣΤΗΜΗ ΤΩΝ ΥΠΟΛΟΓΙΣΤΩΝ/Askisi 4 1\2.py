import random
w1 = 0
w2 = 0
d = 0
for k in range(100):
    xartia = []
    figures = ["J", "Q", "K"]
    xarti = [i for i in range(1, 11)] + figures
    color = ["H", "S", "C", "D"]
    for i in xarti:
        for j in color:
            xartia.append([i,j])
    random.shuffle(xartia)
    player1=[]
    sum1=0
    while sum1<16:
        sum1=0
        player1.append(xartia.pop())
        # print (player1)
        for card in player1:
            if card[0] in figures:
                sum1=sum1+10
            else:
                sum1=sum1+card[0]
        print(sum1)
    if sum1>21:
        w2 = w2 + 1
        print("P2 wins!")
    else:
        '''
        sxolia pollwn
        grammwn
        '''

        print("P2 joins the game") #let me add one more player
        player2=[]
        sum2=0
        while sum2<16:
            sum2=0
            player2.append(xartia.pop())
            # print (player2)
            for card in player2:
                if card[0] in figures:
                    sum2=sum2+10
                else:
                    sum2=sum2+card[0]
            print(sum2)
        if sum2>21:
            sum2=0
        if sum1>sum2:
            w1 = w1 + 1
            print("P1 wins!")
        elif sum2>sum1:
            w2 = w2 + 1
            print("P2 wins!")
        else:
            d = d + 1
            print("draw!")
print ("Out of 100 games player 1 won ", int(w1), "player 2 ", int(w2), "and draws were ", int(d))
