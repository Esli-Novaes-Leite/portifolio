print ("guerreiro(1)")
print ("mago(2)")
classe=input("insira sua classe")
from random import randint

poder=0
vidainit=6
vida = vidainit
mvidainit=20
mvida=mvidainit
mdano=3
restaura=0
probabilidade =0
danocausado=0
danosofrido=3

if classe == '1':
    probabilidade = 8
    poder=randint(5,10)
elif classe=='2':
    poder=randint(7,15)
    probabilidade =10

print("ó ceus um monstro selvagem apareceu oque voce fara?")
while vida>0: 
    print (f'seu poder é de:{poder}')
    print (f'sua vida é de:{vida}')
    while mvida>0:
        print (f'a vida do monstro ={mvida}')
        print (f'sua vida é ={vida}')
        print(f'seu poder agora é de ={poder}')
        defesamonstro=False
        defesa = False
        ação=input("ataque(1) defesa(2)cura(3)descancar(4)") 
        if ação == '1':
            if poder-2>0:
                if classe=='1':    
                    if not defesamonstro:
                        danocausado = randint(0,probabilidade)
                        mvida = int(mvida) - int(danocausado)
                        poder-=2
                    else:
                        print ('o monstro se defendeu')
                if classe=='2':    
                    if not defesamonstro:
                        danocausado = randint(3,probabilidade)
                        mvida = int(mvida) - int(danocausado)
                        poder-=2
                        print (f'a vida do monstro ={mvida}')
                        print (f'sua vida é ={vida}')
                        print(f'seu poder agora é de ={poder}')
                    else:
                        print ('o monstro se defendeu') 
            else:
                print('poder insuficiente descanse')
        elif ação == '2':                              
            if classe =='2' and poder-1<=0:
                print ('poder insuficiente')
                
            else:
                 defesa=True
            if classe=='2':
                    poder-1
        elif ação=='3':
            if vida<=19:
                if classe == '2':
                    vida += 2
                    print (f'sua vida agora é {vida}')  
                elif classe == '1':
                    vida+=1 
                print (f'sua vida agora é {vida}')
            else:
                print ('vida cheia')                                       
        elif ação=='4':
            if poder < 10:
                restaura=randint(1,5)
                poder = int(poder) +int(restaura)
                print (f'seu poder agora é de{poder}')
            else:
                print('seu poder ja esta no maximo')    
        escolha_monstro = randint(1,2)
        if escolha_monstro == 1:
            if not defesa:
                vida -= danosofrido
                print('o monstro te atacou')
        elif escolha_monstro == 2:
            defesamonstro = True
            print ('o monstro se esquivou')                  
    print ('monstro derrotado')
    decisao=input('continuar(1)sair(2)')
    if decisao =='1':
        mvidainit += 10
        mvida = mvidainit
        mdano += 3
        vidainit += 5
        vida = vidainit
        probabilidade += 3
        
    else:
        print('saindo do jogo')   
print('derrota')