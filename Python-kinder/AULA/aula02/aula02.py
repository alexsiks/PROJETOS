from tkinter import *

app=Tk()
app.title("Aula 02")
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
vemail=Text(app)
vemail.place(x=10,y=250,width=400,height=80)



app.mainloop()