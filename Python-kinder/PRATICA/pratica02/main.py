
from tkinter import *
from tkinter import ttk

def caucular():
    ve=cb_lista.get()    
    print(ve)
     


##--------------------------configurações de janela----------------##
root = Tk()
root.title("Janela 1")
root.geometry("640x480")
root.configure(background="blue")

#-----------------------------drop menu------------------------------#

option = ['SOLICITAÇÃO','RECLAMAÇÃO','INFORMAÇÃO','ELOGIO','SUGESTÃO','ASSISTÊNCIA TÉCNICA']

lista_motivos= StringVar(root)
lista_motivos.set(option[0])

cb_lista=OptionMenu(root,lista_motivos,*option)
cb_lista.pack()

##----------------------------Caixa de entrada----------------------##

Label(root,text="",background="blue", foreground="white").place(x=8,y=10)
input1=Entry(root)
input1.place(x=10,y=30)

Label(root,text="Informe a porcentagem:",background="blue", foreground="white").place(x=8,y=50)
input2=Entry(root)
input2.place(x=10,y=70)


##-----------------------------botoes--------------------------------##

button1 = Button(root,text="Caucular",command=caucular)
button1.place(x=50,y=135)



root.mainloop()







