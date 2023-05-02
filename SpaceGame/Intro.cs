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
        /// This functiom initializes all the components of the form and displays a Label.
        public Intro()
        {
            InitializeComponent();
            storyLabel.Text = "Nikola este un fizician, chimist, matematician și programator genial, în timp ce lucra în laborator la proiectul său ce avea să revoluționeze omenirea, acesta aude o știre la TV. Se pare că un virus scăpat din laborator a început să facă ravagii, oamenii devenind adevărați zombie, acesta se raspândea inimaginabil de rapid. Odată ce a auzit știrile acesta s-a dus să își informeze colegii, dar deja era prea târziu, tot laboratorul era deja infectat. Din fericire acesta a reușit să se barichadeze în biroul său."+ '\n' + "După o lună Nikola a reușit să iasă din laborator prin sistemul de ventilație și cu greutate a ajuns la mașina sa încă funcțională.\nÎn timp ce conducea și-a amintit de proiectul spațial pe care acesta îl avuse cu bunul său prieten Dijkstra și îl părăsise cu mult timp în urmă. Ajuns la buncăr acesta a reușit să spargă codul de la intrare și să intre. Acolo a găsit racheta pe care o construiau, dar înca nu era terminată.\nDintr-odată membrii guvernului rămași în viață au transmis prin radio un mesaj. Aceștia își vor stabili baza pe Stația Internațională pentru a găsi în liniște un leac.\nAjută-l pe Nikola să reconstruiască racheta și să ajungă pe Stația Internațională pentru a ajuta la găsirea leacului.";
        }

    }
}
