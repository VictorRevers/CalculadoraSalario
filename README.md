# CalculadoraSalario
Calculadora de salários com  Windows Form .NET C#

# Questão:
Elabore um programa de computador que efetue o cálculo do salário de um profissional horista. 
O programa deve solicitar as horas trabalhadas, o valor da hora e o percentual de desconto para apresentar o salário bruto, o total de descontos e o salário líquido.

# Arquivo com as funcionalidades: 
https://github.com/VictorRevers/CalculadoraSalario/blob/master/Cap02_Ex03/Form1.cs

```
private void button1_Click(object sender, EventArgs e)
{
            float val_hora = float.Parse(textBox1.Text);
            float horas_trab = float.Parse(textBox2.Text);
            float porc_desconto = float.Parse(textBox3.Text);

            float bruto = (val_hora * horas_trab) * 30;
            float desconto = bruto * (porc_desconto / 100);
            float liquido = bruto - desconto;

            label5.Text += "\n" +bruto.ToString("##,##0.00");
            label6.Text += "\n"+desconto.ToString("##,##0.00");
            label7.Text += "\n"+liquido.ToString("##,##0.00");
}
```
        
 # Formulário:
 ![image](https://user-images.githubusercontent.com/60626825/165978556-8404dcde-d0a9-4858-a8d1-83908498a049.png)
 
 # Execução do Formulário:
 ![image](https://user-images.githubusercontent.com/60626825/165978756-f06dd29d-6603-4ed4-8ebe-face3eee803e.png)

 



