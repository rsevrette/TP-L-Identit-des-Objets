class Produit {
    private string codeArticle;
    private string designation;
    private double prix;
    public Produit(string code, string nom, double px) {
        this.codeArticle = code;
        this.designation = nom;
        this.prix = px;
    }
    public string GetCodeArticle() {
        return codeArticle;
    }

    public override string ToString()
    {
        return $"Produit {{ codeArticle={codeArticle}, designation={designation}, prix={prix} }}";
    }
}
