# TaskMate - Application de Gestion de Tâches

Une application **Windows Forms** moderne et intuitive pour gérer vos tâches quotidiennes, améliorer votre productivité et rester organisé.

![TaskMate](https://img.shields.io/badge/Version-1.0.0-blue)
![VB.NET](https://img.shields.io/badge/VB.NET-4.7.2-orange)
![SQLite](https://img.shields.io/badge/Database-SQLite-green)

---

## 🎯 Fonctionnalités Principales

✅ **Ajouter des tâches** - Créez des tâches avec titre, description, date d'échéance et priorité  
✅ **Visualiser les tâches** - Affichage clair avec filtres par date, priorité et statut  
✅ **Modifier et supprimer** - Mettez à jour ou supprimez vos tâches facilement  
✅ **Marquer comme complète** - Suivez votre progression  
✅ **Persistance des données** - Vos tâches sont sauvegardées automatiquement avec SQLite  

---

## 🎨 Filtres Disponibles

- 📋 **Toutes** - Affiche toutes les tâches
- ⏳ **En cours** - Tâches non complétées
- ✓ **Complétées** - Tâches terminées
- ⚠️ **En retard** - Tâches dépassant la date d'échéance
- 📅 **Aujourd'hui** - Tâches dues aujourd'hui

---

## 🛠️ Architecture

```
TaskMate/
├── Models/              # Classes de données (Task)
├── Database/            # Gestion de la base de données SQLite
├── Services/            # Logique métier (TaskService)
├── Forms/               # Interface utilisateur (MainForm, AddEditTaskForm)
└── Program.vb           # Point d'entrée de l'application
```

### Architecture en Couches

- **Presentation Layer** (Forms) → Interface utilisateur
- **Business Logic Layer** (Services) → Logique métier
- **Data Access Layer** (Database) → Accès aux données
- **Models** → Classes de données

---

## 💾 Stockage des Données

- **Base de données**: SQLite
- **Localisation**: `C:\Users\{user}\AppData\Roaming\TaskMate\tasks.db`
- **Persévérance**: Les données restent sauvegardées après la fermeture

---

## 🚀 Installation & Utilisation

### Prérequis
- Visual Studio 2017 ou supérieur
- .NET Framework 4.7.2 ou supérieur
- System.Data.SQLite NuGet Package

### Installation

1. **Cloner le repository**
   ```bash
   git clone https://github.com/kadar4/TaskMate.git
   ```

2. **Ouvrir le projet**
   - Ouvrir `TaskMate.sln` dans Visual Studio

3. **Installer les dépendances NuGet**
   - Dans Package Manager Console :
   ```
   Install-Package System.Data.SQLite
   ```

4. **Compiler et exécuter**
   - F5 ou Ctrl+F5

### Utilisation de base

1. **Ajouter une tâche** 
   - Cliquez sur "➕ Ajouter une tâche"
   - Remplissez les champs (titre obligatoire)
   - Sélectionnez la priorité (Basse, Moyenne, Haute)
   - Cliquez sur "Enregistrer"

2. **Consulter les tâches**
   - La liste apparaît automatiquement
   - Utilisez les filtres pour trier

3. **Modifier une tâche**
   - Double-cliquez sur une tâche, OU
   - Sélectionnez et cliquez "✏️ Modifier"

4. **Marquer comme complète**
   - Sélectionnez la tâche
   - Cliquez "✓ Compléter"

5. **Supprimer une tâche**
   - Sélectionnez la tâche
   - Cliquez "🗑️ Supprimer"

---

## 👥 Utilisateurs Cibles

- 💼 **Professionnels** - Gérer les tâches quotidiennes et les projets
- 🎓 **Étudiants** - Suivre les devoirs et les échéances
- 👨‍👩‍👧 **Parents** - Organiser les tâches familiales
- 💻 **Freelancers** - Gérer les tâches multi-projets
- 🎪 **Organisateurs d'événements** - Coordonner les détails

---

## 📋 Niveaux de Priorité

| Priorité | Description | Couleur |
|----------|-------------|--------|
| **Basse** | Tâches peu urgentes | 🟢 |
| **Moyenne** | Tâches normales | 🟡 |
| **Haute** | Tâches urgentes | 🔴 |

---

## 📊 Statuts des Tâches

| Statut | Description |
|--------|-------------|
| **En cours** | Tâche non complétée avec date future |
| **En retard** | Tâche non complétée avec date passée |
| **Complétée** | Tâche marquée comme terminée |

---

## 🔧 Dépendances

- **Framework**: .NET Framework 4.7.2+
- **UI**: Windows Forms
- **Database**: System.Data.SQLite
- **Language**: VB.NET

---

## 📝 Améliorations Futures

- 🌙 Mode sombre
- 📊 Statistiques et graphiques
- 🔔 Notifications pour les tâches en retard
- ☁️ Synchronisation cloud
- 📱 Version mobile
- 🌍 Support multilingue
- 📤 Export en PDF/Excel

---

## 📞 Support

Pour toute question ou problème :
- 📧 Créer une issue sur GitHub
- 💬 Consulter la documentation

---

## 📜 Licence

Ce projet est distribué sous licence libre. Libre d'utilisation et de modification.

---

## 👨‍💻 Auteur

**Kadar4** - 2025-2026

---

## 🙏 Remerciements

Merci d'utiliser **TaskMate** pour améliorer votre productivité ! 🚀

---

**Améliorez votre productivité avec TaskMate! ✨**
