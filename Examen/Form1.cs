namespace Examen;

public partial class Form1 : Form
{

    Label? lblMon;
    ComboBox? cbmMonedas;
    Label? lblMonto;
    Label? lblConv;
    TextBox? txtMonto;
    Button? btnCalcular;
    Label? lblPeso;
    TextBox? txtPeso;
    Label? lblCad;
    TextBox? txtCad;
    Label? lblEu;
    TextBox? txtEu;
    Label? lblYen;
    TextBox? txtYen;
    Label? lblUsd;
    TextBox? txtUsd;

    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes(){
        this.Size = new Size(300,350);
        //Etiqueta Moneda
        lblMon = new Label();
        lblMon.Text = "Moneda";
        lblMon.AutoSize=true;
        lblMon.Location=new Point(10,10);
        this.Controls.Add(lblMon);

        //ComboBox Monedas
        cbmMonedas = new ComboBox();
        cbmMonedas.Items.Add("USD - Dólar Estadounidense");
        cbmMonedas.Items.Add("MXN - Peso Mexicano");
        cbmMonedas.Items.Add("CAD - Dólar Canadiense");
        cbmMonedas.Items.Add("EUR - Euro");
        cbmMonedas.Items.Add("JPY - Yen Japonés");
        cbmMonedas.Location = new Point(10,40);
        cbmMonedas.SelectedValueChanged+= new EventHandler(ElegirCalcular);

        this.Controls.Add(cbmMonedas);

        //Etiqueta Monto
        lblMonto = new Label();
        lblMonto.Text = "Monto";
        lblMonto.AutoSize = true;
        lblMonto.Location = new Point(180, 10);
        this.Controls.Add(lblMonto);


        //TextBox Monto
        txtMonto =new TextBox();
        txtMonto.Size = new Size(80,40);
        txtMonto.Location = new Point(180,40);
        this.Controls.Add(txtMonto);

        //Button Calcular
        btnCalcular = new Button();
        btnCalcular.Text=" Calcular ";
        btnCalcular.AutoSize=true;
        btnCalcular.Location= new Point(180,80);
        this.Controls.Add(btnCalcular);
        btnCalcular.Click+= new EventHandler(btnCalcularClick);

        //Etiqueta Conversiones
        lblConv = new Label();
        lblConv.Text = "Conversiones";
        lblConv.AutoSize = true;
        lblConv.Location = new Point(10, 100);
        this.Controls.Add(lblConv);

        // Etiqueta Peso
        lblPeso = new Label();
        lblPeso.Text = "MXN - Peso";
        lblPeso.AutoSize = true;
        lblPeso.Location = new Point(10, 120);
        this.Controls.Add(lblPeso);
        lblPeso.Visible=true;

        //TextBox Peso
        txtPeso =new TextBox();
        txtPeso.Size = new Size(80,40);
        txtPeso.Location = new Point(180,120);
        this.Controls.Add(txtPeso);
        txtPeso.Visible=true;

        // Etiqueta Dolar Cad
        lblCad = new Label();
        lblCad.Text = "CAD - Dolar";
        lblCad.AutoSize = true;
        lblCad.Location = new Point(10, 145);
        this.Controls.Add(lblCad);
        lblCad.Visible=true;

        //TextBox Dolar Cad
        txtCad =new TextBox();
        txtCad.Size = new Size(80,40);
        txtCad.Location = new Point(180,145);
        this.Controls.Add(txtCad);
        txtCad.Visible=true;

        // Etiqueta Euro
        lblEu = new Label();
        lblEu.Text = "EUR - Euro";
        lblEu.AutoSize = true;
        lblEu.Location = new Point(10, 170);
        this.Controls.Add(lblEu);
        lblEu.Visible=true;

        //TextBox Euro
        txtEu =new TextBox();
        txtEu.Size = new Size(80,40);
        txtEu.Location = new Point(180,170);
        this.Controls.Add(txtEu);
        txtEu.Visible=true;
        
        // Etiqueta Yen
        lblYen = new Label();
        lblYen.Text = "JPY - Yen Japonés";
        lblYen.AutoSize = true;
        lblYen.Location = new Point(10, 195);
        lblYen.Visible=true;
        this.Controls.Add(lblYen);

        //TextBox Yen
        txtYen =new TextBox();
        txtYen.Size = new Size(80,40);
        txtYen.Location = new Point(180,195);
        this.Controls.Add(txtYen);
        txtYen.Visible=true;

        // Etiqueta USD
        lblUsd = new Label();
        lblUsd.Text = "USD - Dolar Estadounidense";
        lblUsd.AutoSize = true;
        lblUsd.Location = new Point(10, 220);
        this.Controls.Add(lblUsd);
        lblUsd.Visible=true;


        //TextBox USD
        txtUsd =new TextBox();
        txtUsd.Size = new Size(80,40);
        txtUsd.Location = new Point(180,220);
        this.Controls.Add(txtUsd);
        txtUsd.Visible=true;
    }

    private void ElegirCalcular(object sender, EventArgs e){
        if(cbmMonedas.SelectedItem!=null){
            if(cbmMonedas.SelectedItem.ToString()=="USD - Dólar Estadounidense"){
                lblUsd.Visible=false;
                txtUsd.Visible=false;
            }

            if(cbmMonedas.SelectedItem.ToString()=="JPY - Yen Japonés"){
                lblYen.Visible=false;
                txtYen.Visible=false;
            }

            if(cbmMonedas.SelectedItem.ToString()=="EUR - Euro"){
                lblEu.Visible=false;
                txtEu.Visible=false;
            }

            if(cbmMonedas.SelectedItem.ToString()=="CAD - Dólar Canadiense"){
                lblCad.Visible=false;
                txtCad.Visible=false;
            }

            if(cbmMonedas.SelectedItem.ToString()=="MXN - Peso Mexicano"){
                lblPeso.Visible=false;
                txtPeso.Visible=false;
            }
        }
    }

    private void btnCalcularClick(object sender, EventArgs e){
        //string calculo= cbmMonedas.SelectedItem.ToString();

        //Esto si se elige Usd
        if(cbmMonedas.SelectedItem.ToString()=="USD - Dólar Estadounidense"){
            string calculo= cbmMonedas.SelectedItem.ToString();
            int montoCad=0;
            int montoPeso=0;
            int montoYen=0;
            int montoEu=0;
            if(txtMonto.Text!=""){
                montoCad = Convert.ToInt32(txtMonto.Text);
                txtCad.Text="$" + (montoCad*1.28).ToString();
                montoPeso = Convert.ToInt32(txtMonto.Text);
                txtPeso.Text="$" + (montoPeso*21.23).ToString();
                montoYen = Convert.ToInt32(txtMonto.Text);
                txtYen.Text="¥" + (montoYen*113.05).ToString();
                montoEu = Convert.ToInt32(txtMonto.Text);
                txtEu.Text= "€" + (montoEu*0.89).ToString();
            }
        }

        //Esto si se elige Cad
        if(cbmMonedas.SelectedItem.ToString()=="CAD - Dólar Canadiense"){
            string calculo= cbmMonedas.SelectedItem.ToString();
            int montoUs=0;
            int montoPeso=0;
            int montoYen=0;
            int montoEu=0;
            if(txtMonto.Text!=""){
                montoUs = Convert.ToInt32(txtMonto.Text);
                txtUsd.Text="$" + (montoUs*0.78).ToString();
                montoPeso = Convert.ToInt32(txtMonto.Text);
                txtPeso.Text="$" + (montoPeso*16.55).ToString();
                montoYen = Convert.ToInt32(txtMonto.Text);
                txtYen.Text="¥" + (montoYen*88.12).ToString();
                montoEu = Convert.ToInt32(txtMonto.Text);
                txtEu.Text="€" + (montoEu*0.69).ToString();
            }
        }

        //Esto si se elige Yen
        if(cbmMonedas.SelectedItem.ToString()=="JPY - Yen Japonés"){
            string calculo= cbmMonedas.SelectedItem.ToString();
            int montoUs=0;
            int montoPeso=0;
            int montoCad=0;
            int montoEu=0;
            if(txtMonto.Text!=""){
                montoUs = Convert.ToInt32(txtMonto.Text);
                txtUsd.Text="$" + (montoUs*0.0088).ToString();
                montoPeso = Convert.ToInt32(txtMonto.Text);
                txtPeso.Text="$" + (montoPeso*0.1878).ToString();
                montoCad = Convert.ToInt32(txtMonto.Text);
                txtCad.Text="$" + (montoCad*0.0113).ToString();
                montoEu = Convert.ToInt32(txtMonto.Text);
                txtEu.Text="€" + (montoEu*0.0078).ToString();
            }
        }

        //Esto si se elige Peso
        if(cbmMonedas.SelectedItem.ToString()=="MXN - Peso Mexicano"){
            string calculo= cbmMonedas.SelectedItem.ToString();
            int montoUs=0;
            int montoYen=0;
            int montoCad=0;
            int montoEu=0;
            if(txtMonto.Text!=""){
                montoUs = Convert.ToInt32(txtMonto.Text);
                txtUsd.Text="$" + (montoUs*0.05).ToString();
                montoYen = Convert.ToInt32(txtMonto.Text);
                txtYen.Text="¥" + (montoYen*5.32).ToString();
                montoCad = Convert.ToInt32(txtMonto.Text);
                txtCad.Text="$" + (montoCad*0.06).ToString();
                montoEu = Convert.ToInt32(txtMonto.Text);
                txtEu.Text="€" + (montoEu*0.04).ToString();
            }
        }

        //Esto si se elige Euro
        if(cbmMonedas.SelectedItem.ToString()=="EUR - Euro"){
            string calculo= cbmMonedas.SelectedItem.ToString();
            int montoUs=0;
            int montoYen=0;
            int montoCad=0;
            int montoPeso=0;
            if(txtMonto.Text!=""){
                montoUs = Convert.ToInt32(txtMonto.Text);
                txtUsd.Text="$" + (montoUs*1.13).ToString();
                montoYen = Convert.ToInt32(txtMonto.Text);
                txtYen.Text="¥" + (montoYen*127.56).ToString();
                montoCad = Convert.ToInt32(txtMonto.Text);
                txtCad.Text="$" + (montoCad*1.45).ToString();
                montoPeso = Convert.ToInt32(txtMonto.Text);
                txtPeso.Text="$" + (montoPeso*23.96).ToString();
            }
        }

        
    }
}
