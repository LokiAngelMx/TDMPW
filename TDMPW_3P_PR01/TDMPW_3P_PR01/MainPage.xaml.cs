using System.ComponentModel;

namespace TDMPW_3P_PR01;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    string nombreImagen = "";
    string listaIngredientes = "Lista de ingredientes:";
    string procedimiento = "";
    string nivelDificultad = "Nivel de dificultad: ";
    string clasificacion = "Clasificacion: ";

    public string NombreImagen
    {
        get => nombreImagen;
        set
        {
            nombreImagen = value;
            OnPropertyChanged();
        }
    }

    public string ListaIngredientes
    {
        get => listaIngredientes;
        set
        {
            listaIngredientes = value;
            OnPropertyChanged();
        }
    }

    public string Procedimiento
    {
        get => procedimiento;
        set
        {
            procedimiento = value;
            OnPropertyChanged();
        }
    }

    public string NivelDificultad
    {
        get => nivelDificultad;
        set
        {
            nivelDificultad = value;
            OnPropertyChanged();
        }
    }

    public string Clasificacion
    {
        get => clasificacion;
        set
        {
            clasificacion = value;
            OnPropertyChanged();
        }
    }

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    void RecetaUno_Clicked(System.Object sender, System.EventArgs e)
    {
        NombreImagen = "receta1.jpeg";
        ListaIngredientes = "Ingredientes:\n\nPasta de elección (penne, fusilli, etc.)\nTomates cherry\nAlbahaca fresca\nMozzarella fresca (bolas pequeñas)\nAceite de oliva\nSal y pimienta\nAjo (opcional)";
        Procedimiento = "Procedimiento:\n\nCocinar la pasta según las instrucciones del paquete.\nCortar por la mitad los tomates cherry.\nPicar finamente la albahaca fresca.\nEn un tazón grande, combinar la pasta cocida, los tomates, la albahaca y las bolas de mozzarella.\nRocía con aceite de oliva y mezcla bien.\nAñade sal, pimienta y ajo picado al gusto.";
        NivelDificultad = "Nivel de Dificultad: 6";
        Clasificacion = "Clasificación: Fácil y saludable.";
    }

    void RecetaDos_Clicked(System.Object sender, System.EventArgs e)
    {
        NombreImagen = "receta2.jpeg";
        ListaIngredientes = "Ingredientes:\n\nSalmón fresco\nLimón\nEneldo fresco\nAceite de oliva\nSal y pimienta";
        Procedimiento = "Procedimiento:\n\nPrecalienta el horno a 180°C (350°F).\nColoca el salmón en una bandeja para hornear.\nExprime el jugo de limón sobre el salmón.\nEspolvorea con eneldo picado.\nRocía con aceite de oliva y sazona con sal y pimienta.\nHornea durante 15-20 minutos o hasta que esté cocido a tu gusto.";
        NivelDificultad = "Nivel de Dificultad: 3";
        Clasificacion = "Clasificación: Fácil y saludable.";
    }

    void RecetaTres_Clicked(System.Object sender, System.EventArgs e)
    {
        NombreImagen = "receta3.jpeg";
        ListaIngredientes = "Ingredientes:\n\nTortillas de maíz o harina\nCarne molida (res o pollo)\nCebolla picada\nPimiento morrón picado\nSalsa de tomate\nQueso rallado\nSal, pimienta y especias al gusto";
        Procedimiento = "Procedimiento:\n\nEn una sartén, sofríe la cebolla y el pimiento hasta que estén tiernos.\nAñade la carne molida y cocina hasta que esté bien dorada.\nAñade la salsa de tomate y las especias al gusto. Deja cocinar a fuego lento.\nCalienta las tortillas en una sartén o en el microondas.\nSirve la carne sobre las tortillas y espolvorea con queso rallado.";
        NivelDificultad = "Nivel de Dificultad: 2";
        Clasificacion = "Clasificación: Fácil y sabroso.";
    }

    void RecetaCuatro_Clicked(System.Object sender, System.EventArgs e)
    {
        NombreImagen = "receta4.jpeg";
        ListaIngredientes = "Ingredientes:\n\nArroz jazmín\nAgua\nSal\nAceite de sésamo\nVerduras variadas (brócoli, zanahoria, pimiento, etc.)\nSalsa de soja";
        Procedimiento = "Procedimiento:\n\nCocina el arroz jazmín según las instrucciones del paquete.\nEn una sartén grande, calienta un poco de aceite de sésamo.\nAñade las verduras picadas y saltea hasta que estén tiernas.\nAñade el arroz cocido a la sartén y mezcla bien.\nRocía con salsa de soja al gusto y sirve caliente.";
        NivelDificultad = "Nivel de Dificultad: 4";
        Clasificacion = "Clasificación: Fácil y nutritivo.";
    }

    void RecetaCinco_Clicked(System.Object sender, System.EventArgs e)
    {
        NombreImagen = "receta5.jpeg";
        ListaIngredientes = "Ingredientes:\n\nGarbanzos cocidos (puedes usar de lata)\n1 cucharada de tahini (pasta de sésamo)\n2 dientes de ajo\nJugo de 1 limón\n2 cucharadas de aceite de oliva\nSal al gusto\nPimentón dulce para decorar (opcional)\nPerejil fresco para decorar";
        Procedimiento = "Procedimiento:\n\nEn una licuadora o procesador de alimentos, combina los garbanzos, tahini, ajo, jugo de limón, y aceite de oliva.\nProcesa hasta obtener una pasta suave. Si está muy espeso, puedes añadir un poco de agua para conseguir la consistencia deseada.\nSazona con sal al gusto.\nTransfiere el hummus a un tazón y decora con un chorrito de aceite de oliva, pimentón dulce y perejil fresco picado.\nSirve con pan pita, verduras crudas o como acompañamiento de tus platos favoritos.";
        NivelDificultad = "Nivel de Dificultad: 1";
        Clasificacion = "Clasificación: Fácil y nutritivo.";
    }
}