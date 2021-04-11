from tkinter import *
import os 
os.system('cls')




def dados():
    
    print("Nome: %s" %vnome.get())
    print("Telefone: %s" %vtelefone.get())
    print("Email: %s" %vemail.get())
    print("Descrição: %s" %vobs.get("1.0",END))



app=Tk()
app.title("Aula 03")
app.geometry("640x480")
app.configure(background="purple")

#N = posição norte
#S= sul
#W= oeste
#E=leste

Label(app,text="Nome",background="purple",foreground="white",anchor=W).place(x=10,y=10,width=100,height=20)
vnome=Entry(app)
vnome.place(x=10,y=40,width=200,height=20)


Label(app,text="Telefone",background="purple",foreground="white",anchor=W).place(x=10,y=80,width=100,height=20)
vtelefone=Entry(app)
vtelefone.place(x=10,y=110,width=100,height=20)


Label(app,text="Email",background="purple",foreground="white",anchor=W).place(x=10,y=150,width=100,height=20)
vemail=Entry(app)
vemail.place(x=10,y=180,width=200,height=20)


Label(app,text="OBS",background="purple",foreground="white",anchor=W).place(x=10,y=220,width=100,height=20)
vobs=Text(app)
vobs.place(x=10,y=250,width=400,height=80)


Button(app,text="Imprimir",command=dados).place(x=10,y=350,width=100,height=20)

app.mainloop()