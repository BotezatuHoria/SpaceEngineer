using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
            textBox1.Text = "Nikola este un fizician, chimist, matematician si programator genial, in timp ce lucra in laborator la proiectul sau ce avea sa revolutioneze omenirea, acesta aude o stire la TV. Se pare ca un virus scapat din laborator a inceput sa faca ravagii, oamenii devenind adevarati zombie, acesta se raspandea inimaginabil de rapid. Odata ce a auzit stirile acesta s-a dus sa isi informeze colegii, dar deja era prea tarziu, tot laboratorul era plin de zombie. Din fericire acesta a reusit sa se barichadeze in biroul sau."+ "\n" + "Dupa o luna...\nDupa o luna Nikola a reusit sa supravietuiasca si sa isi faca arme pentru a supravietui invaziei si a iesit din laborator prin ventul din tavan si cu greutate a ajuns la masina sa inca intacta, in timp ce conducea si a amintit de proiectul spatial pe care acesta il avuse cu bunul sau prieten Dijkstra si il parasise cu mult timp in urma.Ajuns la buncar acesta a reusit sa sparga codul de la intrare si sa intre.Acolo a gasit racheta pe care o construiau dar, botul, structura,0 aripile si motorul inca nu erau terminate, acum Nikola are la dispozitie 10 zile sa isi termine racheta deoarece membrii aramtei ramasi in viata au zis ca vor pleca in spatiu si vor detona o bomba asupra pamantului care va anihila orice fiinta de pe pamant deoarece nu a mai ramas niciun om de stiinta ca sa poata crea un leac deoarece toti au fost transfoemati in timpul incercarilor lor disperate de a salva omenirea.";
        }

        private void Intro_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            new Game().ShowDialog();
        }
    }
}
