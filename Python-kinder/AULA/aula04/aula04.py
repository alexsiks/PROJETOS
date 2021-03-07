from tkinter import *
import os
import banco
os.system('cls')




def dados():
    if tb_nome.get() != " ":
        vnome=tb_nome.get()
        vfone=tb_fone.get()
        vemail=tb_email.get()
        vobs=tb_obs.get("1.0",END)
        vquery="insert into tb_contatos(T_nomecontato,T_telefone,T_emailcontato,t_obs) values ("+vnome+" ',"+vfone+" ',"+vemail+" ',' "+vobs+" ')"
   
        banco.dml(vquery)
        tb_nome.delete(0,END)
        tb_fone.delete(0,END)
        tb_email.delete(0,END)
        tb_obs.delete("1.0",END)
        print("Dados Gravados com sucesso.")

    else:
        print("Erro")
   

app=Tk()
app.title("Aula 03")
app.geometry("640x480")
app.configure(background="purple")

#N = posição norte
#S= sul
#W= oeste
#E=leste

Label(app,text="Nome",background="purple",foreground="white",anchor=W).place(x=10,y=10,width=100,height=20)
tb_nome=Entry(app)
tb_nome.place(x=10,y=40,width=200,height=20)


Label(app,text="Telefone",background="purple",foreground="white",anchor=W).place(x=10,y=80,width=100,height=20)
tb_fone=Entry(app)
tb_fone.place(x=10,y=110,width=100,height=20)


Label(app,text="Email",background="purple",foreground="white",anchor=W).place(x=10,y=150,width=100,height=20)
tb_email=Entry(app)
tb_email.place(x=10,y=180,width=200,height=20)


Label(app,text="OBS",background="purple",foreground="white",anchor=W).place(x=10,y=220,width=100,height=20)
tb_obs=Text(app)
tb_obs.place(x=10,y=250,width=400,height=80)




Button(app,text="Imprimir",command=dados).place(x=10,y=350,width=100,height=20)

Button(app,text="Buscar",command=dados).place(x=150,y=350,width=100,height=20)


app.mainloop()