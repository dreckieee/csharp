### VehicleFleet
**Phase:** Phase 3 — OOP & Inheritance
A polymorphic fleet manager demonstrating abstract classes, inheritance, and virtual method overriding across Car, Truck, and Motorcycle types.

## Concepts Practiced
- Abstract base class with abstract and virtual methods
- Inheritance and constructor chaining via base()
- Polymorphic list typed as List<Vehicle>
- base.DisplayInfo() chaining to avoid duplication
- Subclass-specific properties and method overrides

## Highlights
- KmPerLiter and FuelTankCapacity lifted to base class after identifying duplication across subclasses
- FuelReport() stays abstract — output differs per vehicle type
- DisplayInfo() is virtual — base prints shared fields, subclasses append their own

## Rules Enforced
- 0 warnings
- One file per class
- private set throughout
- Always use braces
---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.