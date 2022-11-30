using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Web.UI.WebControls;

namespace DDLEstadosCidades
{
    public partial class DDLEstadosCidades : System.Web.UI.Page
    {
        private static DataSet cargaXML = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargaXML.ReadXml(Path.Combine(AppContext.BaseDirectory, "Resources/localidade.xml"));

                cargaXML.Tables["estado"].AsEnumerable().ToList().ForEach((c) =>
                {
                    ddlEstado.Items.Add(new ListItem
                    {
                        Text = c["nome"].ToString(),
                        Value = c["idestado"].ToString()
                    });
                });
            }
        }

        protected void ddlEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlEstado.SelectedIndex > 0)
            {
                ddlCidade.Items.Clear();

                lblSelecaoEstadoCidade.Text = "";

                ddlCidade.Items.Add(new ListItem { Text = "Selecione" });

                cargaXML.Tables["cidade"].Select(string.Format("idestado = {0}", ddlEstado.SelectedValue))
                    .ToList().ForEach((c) =>
                    {
                        ddlCidade.Items.Add(new ListItem
                        {
                            Text = c["nome"].ToString(),
                            Value = c["idcidade"].ToString()
                        });
                    });
            }
            else
            {
                ddlCidade.Items.Clear();

                ddlCidade.Items.Add(new ListItem { Text = "Selecione" });

                lblSelecaoEstadoCidade.Text = "Selecione um Estado";
            }
        }

        protected void ddlCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCidade.SelectedIndex > 0)
                lblSelecaoEstadoCidade.Text = string.Format("Selecionado a Cidade de {0} do Estado do {1}", ddlCidade.SelectedItem.Text, ddlEstado.SelectedItem.Text);
            else
                lblSelecaoEstadoCidade.Text = "Selecione uma Cidade";
        }
    }
}