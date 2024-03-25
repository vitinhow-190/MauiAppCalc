namespace MauiAppCalc
{
    public partial class MainPage : ContentPage

    {
        String? operacao = null;

        double memoria_calc_pre_operacao = 0;
        double memoria_calc_pos_operacao = 0;

        string para_aparecer_no_visor = "";


        public MainPage()
        {
            InitializeComponent();
        }

        private void remover_sinais_visor() 
        {
            if(para_aparecer_no_visor == "+" ||
                para_aparecer_no_visor == "-" ||
                para_aparecer_no_visor == "*" ||
                para_aparecer_no_visor == "/") 
            {
                para_aparecer_no_visor = " ";
            }
        }

         

        private void Zerar_Clicked(object sender, EventArgs e)
        {
            visor.Text = "0";
            para_aparecer_no_visor = "";
            memoria_calc_pre_operacao = 0;
            memoria_calc_pos_operacao = 0;
            operacao = null;
        }
        private void maismenos_clicked(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(visor.Text);
            valor = valor * -1;
            visor.Text = valor.ToString();

        }
        private void Porcento_Clicked(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(visor.Text);
            valor = valor / 100;
            visor.Text = valor.ToString();

        }
        private void Dividir_Clicked(object sender, EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            para_aparecer_no_visor = "/";
            operacao = "/";
            visor.Text = para_aparecer_no_visor;
        }
        private void Num7_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += Num7.Text;
            visor.Text = para_aparecer_no_visor;

        }
        private void Num8_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += Num8.Text;
            visor.Text = para_aparecer_no_visor;
        }
        private void Num9_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += Num9.Text;
            visor.Text = para_aparecer_no_visor;
        }
        private void Multiplicar_Clicked(object sender, EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            para_aparecer_no_visor = "*";
            operacao = "*";
            visor.Text = para_aparecer_no_visor;
        }
        private void Num4_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += Num4.Text;
            visor.Text = para_aparecer_no_visor;
        }
        private void Num5_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += Num5.Text;
            visor.Text = para_aparecer_no_visor;
        }
        private void Num6_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += Num6.Text;
            visor.Text = para_aparecer_no_visor;
        }
        private void Subtrair_Clicked(object sender, EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            para_aparecer_no_visor = "-";
            operacao = "-";
            visor.Text = para_aparecer_no_visor;
        }
        private void Num1_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += Num1.Text;
            visor.Text = para_aparecer_no_visor;
        }
        private void Num2_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += Num2.Text;
            visor.Text = para_aparecer_no_visor;
        }
        private void Num3_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += Num3.Text;
            visor.Text = para_aparecer_no_visor;
        }
        private void Somar_Clicked(object sender, EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            para_aparecer_no_visor = "+";
            operacao = "+";
            visor.Text = para_aparecer_no_visor;
        }
        private void Num0_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += Num0.Text;
            visor.Text = para_aparecer_no_visor;
        }
        private void Ponto_Clicked(object sender, EventArgs e)
        {
            
        }
        private void Igual_Clicked(object sender, EventArgs e)
        {
            try 
            {
                memoria_calc_pos_operacao = Convert.ToDouble(visor.Text);
                double resultado = 0;

                switch (operacao)
                {
                    case "+":

                        resultado = memoria_calc_pre_operacao
                            + memoria_calc_pos_operacao;
                        break;

                    case "-":

                        resultado = memoria_calc_pre_operacao
                            - memoria_calc_pos_operacao;
                        break;

                    case "*":

                        resultado = memoria_calc_pre_operacao
                            * memoria_calc_pos_operacao;
                        break;

                    case "/":

                        resultado = memoria_calc_pre_operacao
                            / memoria_calc_pos_operacao;
                        break;
                }

                visor.Text = resultado.ToString();
            
            }catch(Exception ex) 
            {
                visor.Text = ex.Message;
            }
        }
       

    }
}
