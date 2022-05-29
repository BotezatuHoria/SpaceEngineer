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
            storyLabel.Text = "Nikola este un fizician, chimist, matematician si programator genial, in timp ce lucra in laborator la proiectul sau ce avea sa revolutioneze omenirea, acesta aude o stire la TV. Se pare ca un virus scapat din laborator a inceput sa faca ravagii, oamenii devenind adevarati zombie, acesta se raspandea inimaginabil de rapid. Odata ce a auzit stirile acesta s-a dus sa isi informeze colegii, dar deja era prea tarziu, tot laboratorul era deja infectat. Din fericire acesta a reusit sa se barichadeze in biroul sau."+ '\n' + "Dupa o luna Nikola a reusit sa iasa din laborator prin sistemul de ventilatie si cu greutate a ajuns la masina sa inca functionala.\nIn timp ce conducea si a amintit de proiectul spatial pe care acesta il avuse cu bunul sau prieten Dijkstra si il parasise cu mult timp in urma. Ajuns la buncar acesta a reusit sa sparga codul de la intrare si sa intre. Acolo a gasit racheta pe care o construiau dar inca nu era terminata.\nDintr-odata membrii guvernului ramasi in viata au transmis prin radio un mesaj. Acestia isi vor stabili baza pe Statia Internationala pentru a gasi in liniste un leac.\nAjuta-l pe Nikola sa reconstruiasca racheta si sa ajunga pe Statia Internationala pentru a ajuta la gasirea leacului.";
        }

        private void Intro_FormClosed(object sender, FormClosedEventArgs e)
        {
            //new Game().ShowDialog();
        }
    }
}
