import random
whitew = 0          #white win count
blackw = 0          #black win count
whitew1 = 0
blackw1 = 0
whitew2 = 0
blackw2 = 0
for i in range (100):
   posfound = False
   pos1found = False
   pos2found = False
   whx = random.randrange (0,8)               #random positions of white rook and black bishop
   why = random.randrange (0,8)
   wh1x = random.randrange (0,7)
   wh1y = random.randrange (0,8)
   wh2x = random.randrange (0,7)
   wh2y = random.randrange (0,7)
   while posfound == False:                   #checks for same position to change it
         blx = random.randrange (0,8)
         bly = random.randrange (0,8)
         if blx != whx and bly != why:
            posfound = True
   while pos1found == False:                   #checks for same position to change it
         bl1x = random.randrange (0,7)
         bl1y = random.randrange (0,8)
         if bl1x != wh1x and bl1y != wh1y:
            pos1found = True
   while pos2found == False:                   #checks for same position to change it
         bl2x = random.randrange (0,7)
         bl2y = random.randrange (0,7)
         if bl2x != wh2x and bl2y != wh2y:
            pos2found = True
   if blx == whx or bly == blx:               #check for rook takes
      whitew = whitew + 1
   if bl1x == wh1x or bl1y == bl1x:               #check for rook takes
      whitew1 = whitew1 + 1
   if bl2x == wh2x or bl2y == bl2x:               #check for rook takes
      whitew2 = whitew2 + 1
   for j in range (8):                        #5head check for bishop
      if whx == (blx-j) and why == (bly-j):
         blackw=blackw + 1
      elif whx == (blx+j) and why == (bly-j):
         blackw=blackw + 1
      elif whx == (blx-j) and why == (bly+j):
         blackw=blackw + 1
      elif whx == (blx+j) and why == (bly+j):
         blackw=blackw + 1
   for j in range (8):
      if wh1x == (bl1x-j) and wh1y == (bl1y-j):
         blackw1=blackw1 + 1
      elif wh1x == (bl1x+j) and wh1y == (bl1y-j):
         blackw1=blackw1 + 1
      elif wh1x == (bl1x-j) and wh1y == (bl1y+j):
         blackw1=blackw1 + 1
      elif wh1x == (bl1x+j) and wh1y == (bl1y+j):
         blackw1=blackw1 + 1
   for j in range (8):
      if wh2x == (bl2x-j) and wh2y == (bl2y-j):
         blackw2=blackw2 + 1
      elif wh2x == (bl2x+j) and wh2y == (bl2y-j):
         blackw2=blackw2 + 1
      elif wh2x == (bl2x-j) and wh2y == (bl2y+j):
         blackw2=blackw2 + 1
      elif wh2x == (bl2x+j) and wh2y == (bl2y+j):
         blackw2=blackw2 + 1
print ("After 100 interesting 8x8 games white won ", whitew ," and black won ", blackw," games")
print ("After 100 interesting 7x8 games white won ", whitew1 ," and black won ", blackw1," games")
print ("After 100 interesting 7x7 games white won ", whitew2 ," and black won ", blackw2," games")
