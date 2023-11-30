# Design Pattern

# Définitions:

**Design Pattern:** Solution à des problèmes fréquemment rencontrés dans le dev. logiciel dans le contexte de programmation POO. Ces design pattern décrivent des objets ainsi que leurs relations qui permettent de résoudre ces problèmes métiers.

> **Livre:** Gang of Four, design Pattern.
>

**Polymorphisme:** Une classe peut avoir plusieurs type différent mais communiquer par la même interface.

**Client:** Code qui s’occupe d’appeler l’implémentation du Design Pattern.

**Encapsulation:** Mécanisme qui permet de rassembler les données et les méthodes au sein d’une même structure. Elle permet de limiter les accès à certains de ces éléments.

# Les familles de design pattern

## Creational Patterns

A pour but de créer des objets tout en aidant à la flexibilité ainsi qu’à la réutilisabilité.

## Structural Patterns

Permet de créer des structures de classe complexe à l’aide de structure plus simple et maintenable.

## Behavioural Patterns

Etend la flexibilité dans les interactions et de la distribution des responsabilité des objets.

# Pattern Mystère - 1 
Il semblerais que le pattern utilisé dans le pattern mystère est celui de Factory. Car les enfants de la super class
Command peuvent alterer le type d'objet qu'ils crées et retournent.

# Pattern Mystère - 2 
Le nouveau pattern mystère est Bridge qui permet de d'étendre de manière indépendante les fonctionnalités d'immatriculation ou de méthode d'affichage de manière indépendante.

# Decorator - Framework 
https://angular.io/api/core/Input
Input est un Decorator Java qui permet d'ajouter des fonctionnalités à un champ et le lie au DOM.
Quand ce champ change de donnée elle renvoi un signal au dom pour ce mettre à jour avec la bonne donnée.

# Iterator Contexte
Iterator à pour but de proposer plusieurs façon d'itérer à travers une collection selon les besoins tout en séparant le "comment" itérer à travers plusieurs class. 
De ce fait l'implémentation de la collection contient uniquement les itérations compatibles pour celui-ci.