<Query Kind="Statements">
  
</Query>

StringBuilder[] builders = new StringBuilder [5];
builders [0] = new StringBuilder ("builder1");
builders [1] = new StringBuilder ("builder2");
builders [2] = new StringBuilder ("builder3");

StringBuilder[] builders2 = builders;
StringBuilder[] shallowClone = (StringBuilder[]) builders.Clone();

builders.Dump();
builders2.Dump();

(builders[0] == builders2[0]).Dump ("Comparing first element of each array");