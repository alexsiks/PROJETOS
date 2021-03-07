from tkinter import * 


app=Tk()

## Titulo da janela
app.title("Protocolo")
## dimensão de janela   
app.geometry("640x480")
## Configurações de janela 
app.configure(background="purple")

txt1=Label(app,text="Curso de python",background="yellow",foreground="black")
txt1.place(x=10,y=10,width=200,height=30)



app.mainloop()