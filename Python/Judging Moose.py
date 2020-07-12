sides = input().split()
l = int(sides[0])
r = int(sides[1])

highest_side = max([r, l]);

if(l <= 0 and r <= 0):
  print('Not a moose')
elif l == r:
  print('Even', l +r)
else:
  print('Odd ',highest_side*2)
