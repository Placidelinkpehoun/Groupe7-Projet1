**Application de Réalité Virtuelle - Labyrinthe Interactif**

**Présentation**

Cette application de réalité virtuelle, développée avec Unity 2018.4.19f1 et le SDK Google VR, plonge l'utilisateur dans un labyrinthe immersif. Le but est d'explorer les couloirs et d'atteindre la sortie en suivant des indices visuels et sonores. Ces indices servent de guides pour éviter les impasses et trouver le bon chemin.

**Guidage et Indices**
L'orientation dans le labyrinthe repose sur un système d'indices combinant couleurs et sons :

Son de référence et liste de couleurs : Dès le début de l'expérience, un son est diffusé avec une liste de lettres. Chaque lettre correspond à l'initiale d'une couleur (en anglais).

Capsules colorées : Disposées à divers endroits du labyrinthe, elles émettent un son distinctif lorsqu'elles sont regardées.

Suivi de l'ordre des couleurs : Pour progresser, il faut suivre l'ordre donné par la liste et ne choisir que les capsules émettant le même son que le son de référence.

Exemple : Si la liste fournie est [R-B-Y], le joueur doit suivre les capsules de couleurs Red (Rouge) → Blue (Bleu) → Yellow (Jaune), tout en s'assurant que les sons correspondent.

En combinant l'ordre des couleurs et l'identification sonore, le joueur navigue à travers le labyrinthe jusqu'à la sortie.

‍**Système de Déplacement : Gaze-Based Movement**

Le système de déplacement repose sur le Gaze-Based Movement (mouvement par regard) :

Fixation d'une direction pendant 3 secondes : L'utilisateur commence à avancer automatiquement.

Pause du mouvement :

[Espace] : Arrête instantanément le déplacement.

[Espace] : Reprend le mouvement.

Ce système offre à la fois liberté d'exploration et contrôle sur l'expérience VR.

**Installation et Exécution**

Prérequis

Unity 2018.4.19f1

SDK Google VR

Un casque de réalité virtuelle compatible (Cardboard, Daydream...)

Clonage et Lancement

Cloner le dépôt :

git clone https://github.com/Placidelinkpehoun/Groupe7-Projet1.git
cd Groupe7-Projet1

Ouvrir le projet avec Unity 2018.4.19f1.

Lancer la scène principale et tester l'expérience en VR.

**Licence**

Ce projet est sous licence [Nom de la licence, ex: MIT, GPL...].

**Liens utiles**

Documentation Google VR : https://developers.google.com/vr

Unity 2018.4.19f1 : https://unity.com/fr/releases/editor/archive

