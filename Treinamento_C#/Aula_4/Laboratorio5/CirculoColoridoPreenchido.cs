using System.Drawing;
namespace Laboratorio5;
public class CirculoColoridoPreenchido : CirculoColorido 
{
    private Color preenchimento;

    public CirculoColoridoPreenchido()
    {
        preenchimento = Color.Pink;
    }

    public CirculoColoridoPreenchido(double x, double y, double r, string c, Color p) : base(x, y, r, c)
    {
        preenchimento = p;
    }

    public override string ToString()
    {
        return base.ToString() + " preenchimento= " + preenchimento.ToKnownColor();
    }
}