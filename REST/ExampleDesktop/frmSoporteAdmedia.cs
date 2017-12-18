using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Model;
using Rest.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleDesktop
{
    public partial class FrmSoporteAdmedia : Form
    {
        #region Propiedades
        private IRESTService<SoporteAdmedia> _RESTSoporteAdmediaService;
        private string _nameColumnSelected = "selected"; 
        #endregion

        #region Constructor
        public FrmSoporteAdmedia()
        {
            InitializeComponent();
            String ApiResourcePath = "http://localhost:51249/api/SoporteAdmedia";
            _RESTSoporteAdmediaService = new RESTService<SoporteAdmedia>(ApiResourcePath, Statics.Token);
        }

        #endregion

        #region Eventos Formulario principal

        private void FrmSoporteAdmedia_Resize(object sender, EventArgs e)
        {
            AutoSizeGrid(UgSoporteAdmedia);
        }

        private void FrmSoporteAdmedia_Load(object sender, EventArgs e)
        {
            AutoSizeGrid(UgSoporteAdmedia);
        }

        #endregion

        #region Ultragrid 

        private void AgregarSelectorMultipleEnGrilla(UltraGrid grid)
        {
            var existeColumna = grid.DisplayLayout.Bands[0].Columns.Exists(_nameColumnSelected);
            if (!existeColumna)
            {
                UltraGridColumn checkColumn = grid.DisplayLayout.Bands[0].Columns.Add(_nameColumnSelected, "");
                checkColumn.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                checkColumn.DataType = typeof(Boolean);

                //Display a checkbox in the column header, where column's data type isBoolean,DefaultableBoolean, or Nullable Boolean.
                grid.DisplayLayout.Bands[0].Columns[_nameColumnSelected].Header.CheckBoxVisibility = HeaderCheckBoxVisibility.WhenUsingCheckEditor;

                //Aligns the Header checkbox to the right of the Header caption
                grid.DisplayLayout.Bands[0].Columns[_nameColumnSelected].Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;

                //The checkbox and the cell values are kept in synch to affect only the RowsCollection 
                grid.DisplayLayout.Bands[0].Columns[_nameColumnSelected].Header.CheckBoxSynchronization = HeaderCheckBoxSynchronization.RowsCollection;

                //La se ve en la primera posicion
                grid.DisplayLayout.Bands[0].Columns[_nameColumnSelected].Header.VisiblePosition = 0;


            }
        }

        private void AgregarFiltrosEnGrilla(InitializeLayoutEventArgs e)
        {
            e.Layout.Override.FilterUIType = FilterUIType.HeaderIcons;
            //Saco el filtro de la columna de seleccion
            UgSoporteAdmedia.DisplayLayout.Bands[0].Columns[_nameColumnSelected].AllowRowFiltering = DefaultableBoolean.False;

        }

        private DataTable ObtenerTipoDeSoportes()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));

            dt.Rows.Add(new object[] { 1, "A" });
            dt.Rows.Add(new object[] { 2, "B" });
            dt.Rows.Add(new object[] { 3, "C" });
            dt.AcceptChanges();
            return dt;
        }

        private ValueList ObtenerSoporte(InitializeLayoutEventArgs e)
        {
            ValueList vl;

            if (!e.Layout.ValueLists.Exists("MyValueList"))
            {
                vl = e.Layout.ValueLists.Add("MyValueList");
                vl.ValueListItems.Add(1, "A");
                vl.ValueListItems.Add(2, "B");
                vl.ValueListItems.Add(3, "C");
            }
            return e.Layout.ValueLists["MyValueList"];
        }

        private void InicializarColumnas(InitializeLayoutEventArgs e)
        {
            UgSoporteAdmedia.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns;
            e.Layout.Bands[0].Columns[0].Header.Caption = "Código de Vehículo";

            e.Layout.Bands[0].Columns[1].Header.Caption = "Medio";
            e.Layout.Bands[0].Columns[2].Header.Caption = "Soporte";
            e.Layout.Bands[0].Columns[3].Header.Caption = "Tipo de Soporte";
            e.Layout.Bands[0].Columns[4].Header.Caption = "Descripción AdMedia";

            //Ocultar una columna
            //ugSoporteAdmedia.DisplayLayout.Bands[0].Columns["IdSoporte"].Hidden = true;

            //Cargo Dropdown Simple
            ValueList valueList = ObtenerSoporte(e);
            e.Layout.Bands[0].Columns[2].ValueList = valueList;
            //--

            //Cargo Ultra Dropdown 
            DataTable tipoDeSoporte = ObtenerTipoDeSoportes();
            this.UltraDropDown1.SetDataBinding(tipoDeSoporte, null);
            this.UltraDropDown1.ValueMember = "ID";
            this.UltraDropDown1.DisplayMember = "Descripcion";
            e.Layout.Bands[0].Columns[3].ValueList = this.UltraDropDown1;
            //--

            //Centrar solo una columna
            //e.Layout.Bands[0].Columns[0].CellAppearance.TextHAlign = HAlign.Center;

            //Centrar todas las columnas
            e.Layout.Bands[0].Override.CellAppearance.TextHAlign = HAlign.Center;
        }

        private void UgSoporteAdmedia_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            AgregarSelectorMultipleEnGrilla(UgSoporteAdmedia);

            AgregarFiltrosEnGrilla(e);

            InicializarColumnas(e);



            //Elimina la barra superior en tiempo de ejecución
            //ugSoporteAdmedia.DisplayLayout.ViewStyleBand = ViewStyleBand.Horizontal;
        }

        private void AutoSizeGrid(UltraGrid ultraGrid)
        {
            int diffWidth = 155;
            int diffHeight = 60;
            ultraGrid.Width = this.Width - diffWidth;
            ultraGrid.Height = this.Height - diffHeight;
        }

        #endregion

        #region Eventos de los botones

        #region Eventos Rest para los botones

        private void BtnGet_Click(object sender, EventArgs e)
        {
            IList<SoporteAdmedia> data = _RESTSoporteAdmediaService.GetByUrlParameter("");
            UgSoporteAdmedia.DataSource = data;
        }

        private void BtnPost_Click(object sender, EventArgs e)
        {
            SoporteAdmedia sop = new SoporteAdmedia()
            {
                CodigoVehiculo = "a",
                DescripcionAdmedia = "b",
                IdMedio = 1,
                IdSoporte = "d",
                IdTipoSoporte = "e"
            };

            _RESTSoporteAdmediaService.Post(sop);

        }

        private void BtnPut_Click(object sender, EventArgs e)
        {
            SoporteAdmedia sop = new SoporteAdmedia()
            {
                CodigoVehiculo = "a",
                DescripcionAdmedia = "b",
                IdMedio = 2,
                IdSoporte = "d",
                IdTipoSoporte = "e"
            };

            _RESTSoporteAdmediaService.Update(sop, "1");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _RESTSoporteAdmediaService.Delete("1");
        }

        #endregion

        private void BtnGetSelected_Click(object sender, EventArgs e)
        {
            //    !Convert.ToBoolean(((UltraGridRow)UIEl.SelectableItem).Cells["IsActive"].Text);
            //    ugSoporteAdmedia.Rows[2].Cells["IsActive"].Text
            var data = UgSoporteAdmedia.Rows.Where(x => x.Cells[_nameColumnSelected].Text == "True");
            MessageBox.Show("Se seleccionaron: " + data.Count() + " filas");
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion
        
    }
}
