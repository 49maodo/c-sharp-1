Objectif : 
Créer un système de gestion pour une institution éducative en utilisant C#. Le système 
doit permettre de gérer des personnes, des enseignants et des étudiants. 
Classes Requises : 
1. `Personne` : - Nom, Prénom
2. - Méthodes : - `afficherDetails()` : affiche les détails de la personne. 
3. `Enseignant` : - herite de la classe `Personne`. - Attributs : Matière enseignée.
4. - Méthodes : - `afficherDetails()` : affiche les détails de l'enseignant. 
5. `Etudiant` : - herite de la classe `Personne`. - Attributs : Niveau d'études.
6. - Méthodes : - `afficherDetails()` : affiche les détails de l'étudiant. 
7. Interface `IPersonne` :
8. - Méthodes : - `ajouterPersonne(Personne personne)` : ajoute une personne à la liste.
9. - `afficherPersonnes()` : affiche les détails de toutes les personnes.
  - `afficherEnseignants()` : affiche les détails de tous les enseignants. 
 - `afficherEtudiants()` : affiche les détails de tous les étudiants. 
6. Classe de Test `GestionPersonnes` :
7. - Contient un menu interactif avec les options :
   - Option 1 : Ajouter une personne.
8. - Option 2 : Afficher toutes les personnes.
   - Option 3 : Afficher tous les enseignants.
   - Option 4 : Afficher tous les étudiants.
   - Option 5 : Quitter. 
Consignes : 
1. Implémentez les classes en suivant les spécifications. 
2. Créez la classe de test (`GestionPersonnes`) avec un menu interactif. 
3. Affichez des messages appropriés pour informer les utilisateurs lors des opérations. 
4. Utilisez des listes pour stocker les personnes dans la classe `IPersonneImpl`. 
5. Testez le système en effectuant différentes opérations dans la classe de test.
