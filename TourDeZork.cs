/**
* Classe TourDeZork
* 
* Contrôle le jeu Tour De Zork
* Crée les ennemis en utilisant le tableau comme référence
* Tableau de référence généré à partir du fichier ennemis.txt
* Utilise les classes Acteur, GenerateurClasse et Niveau pour les tâches spécifiques
* 
* Création : 21-11- 25
* Par : Frédérik Taleb
*
* Modification: 21-12-01
* Par : Frédérik Taleb
*/
using System;
using System.IO;

namespace Labo_TDZ_final02
{
    class TourDeZork
    {
        public Acteur[] Ennemis { get; set; }
        public Acteur Joueur { get; set; }
        public Acteur Ennemi { get; set; }
        public Niveau Niveau { get; set; }
        public int EtatJeux { get; set; } = 0;

        /**
        * Constructeur qui :
        * 
        * Lit le fichier ennemis.txt
        * Crée un Acteur avec chaque ligne lue
        * Insère les acteurs créés dans le tableau des ennemis
        *
        */
        public TourDeZork()
        {
            // Initialiser le tableau des ennemis selon le nombre de lignes dans le fichier ennemis.txt

            // Tant qu'il y a des ligne dans le fichier ennemis.txt
            //    Lire une ligne
            //    Transformer la ligne en tableau de string
            //    Utiliser la méthode DecoderEnnemi pour mettre un acteur à la case en cours du tableau Ennemis
            // Fin Tant que
            // Ne pas oublier de fermer le lecteur de fichier

            // Initialiser une nouvelle instance pour l'attribut Niveau

            // Utiliser la méthode CreerEnnemi pour assigner une instance d'Acteur à l'attribut Ennemi 
        }
        /**
        * Méthode qui affiche le menu principal du jeu
        */
        public void AfficherMenuPrincipal()
        {
            // Afficher le menu principal
            // "Bienvenue à la tour de Zork, jusqu'où pourras-tu aller?\n  1.Nouvelle partie\n  2.Quitter"

            // Valider que la réponse au menu est un nombre entier et qu'il s'agit de 1 ou 2

            // Si la réponse est Quitter (2) assigner -1 à EtatJeux
            // Si la réponse est Nouvelle partie (1) assigner 1 à EtatJeux
        }
        /**
        * Méthode qui crée le personnage principal en utilisant 
        * une instance de la classe GenerateurClasse
        * Passe en mode exploration une fois le joueur créé
        */
        public void CreerPersonnage()
        {
            // Créer une instance de la Classe GenerateurClasse
            // Utiliser la méthode GenererClasse pour assigner à l'attribut joueur une instance de la classe Acteur
            // Assigner 2 à EtatJeux
        }
        /**
        * Méthode qui permet l'exploration d'un étage
        * Elle utilise Niveau et ses méthodes pour afficher la carte et déplacer le joueur
        *  tant que l'état du jeu est à 2
        */
        public void ExplorerNiveau()
        {
            // Tant que EtatJeux est à 2
            //    Nettoyer la console
            //    Afficher la carte
            //    Déplacer le joueur selon la clé saisie
            //    Si on est sur la case de l'ennemi on passe en mode combat, EtatJeux devient 3
            //    Si on est sur la case de sortie on passe au prochain niveau en changeant EtatJeux pour 4
            // Fin Tant que
        }
        /**
        * Méthode qui gère le combat entre le personnage et son ennemi
        * La logique est presque exactement la même que celle du dernier laboratoire sur le combat
        * On utilise une initiative aléatoire : agilite + nb entre 1 et 10
        * Quand le joueur gagne on revient à l'état d'exploration (2)
        * S'il perd on revient au menu principal (état 1)
        */
        public void Combattre()
        {
            // Initialiser les variables et instance pour l'initiative

            // Tant que les 2 opposants sont vivants
            //    Nettoyer la console
            //    Afficher le nom de l'ennemi que l'on combat présentement
            //    Afficher l'état de chaque combatant
            //    Générer une initiative pour chaque combatant
            //    Celui qui a l'initiative la plus haute attaque en premier et l'autre attaque seulement s'il est encore vivant
            //    Si l'initiative est égale les deux attaquent en même temps
            //    Avant de passer à la prochaine attaque on demande d'appuyer sur une touche pour continuer
            // Fin Tant que
        
            // Si le joueur est vivant
            //    Nettoyer la console et afficher un message de victoire
            //    Demander d'appuyer sur une touche pour continuer
            //    Enlever l'ennemi du niveau
            //    Passer au mode exploration en mettant EtatJeux à 2
            // Sinon
            //    Nettoyer la console et afficher un message de défaite
            //    Demander d'appuyer sur une touche pour continuer
            //    Assigner une nouvelle instance de Niveau à l'attribut pour le niveau
            //    Générer un nouvel ennemi avec la méthode CreerEnnemi
            //    Revenir à l'affichage du menu principal en assignant 0 à EtatJeux
            // Fin Si
        }
        /**
        * Méthode qui gère le changement de niveau et la création du nouvel ennemi pour ce niveau
        */
        public void ChangerNiveau()
        {
            // Nettoyer la console
            // Afficher un message de transition de niveau et attendre que le joueur appuie sur une touche pour continuer
            // Assigner une nouvelle instance de Niveau à l'attribut du même nom
            // Creer un nouvel ennemi
            // Passer en mode exploration, EtatJeux = 2
        }
        /**
        * Méthode qui utilise le tableau des modèles d'ennemi pour créer une nouvelle instance 
        * et l'assigner à l'attribut correspondant... Ennemi
        */
        private void CreerEnnemi()
        {
            // Utiliser un nombre aléatoire pour sélectionner une case du tableau Ennemis
            // Assigner une nouvelle instance d'Acteur à l'attribut Ennemi
            // Pour le constructeur de Acteur on copie les attributs de l'ennemi dans les paramètres
        }
        /**
        * Méthode qui transforme le tableau des stats d'ennemis en une instance de la classe Acteur
        * et retourne cette instance
        *
        * @return une instance de la classe Acteur
        */
        private Acteur DecoderEnnemi(string[] ennemi)
        {
            // Utiliser les cases du tableau pour remplire les paramètres 
            // du constructeur de Acteur
            // retourner l'instance de la classe Acteur

            // ceci est un return bidon pour satisfaire les conditions de la méthode
            // changez le pour répondre aux exigences de la méthode
            return null;
        }
    }
}