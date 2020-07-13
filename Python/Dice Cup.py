inpt = input().split()

N, M = int(inpt[0]), int(inpt[1])

nrs_list = [N, M]

if N == M:
  print(M+1)
else:
  for i in range(min(nrs_list)+1, max(nrs_list)+2, 1):
    print(i)
