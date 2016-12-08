// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Chocolatey" file="GlobalSuppressions.cs">
//   Copyright 2014 - Present Rob Reynolds, the maintainers of Chocolatey, and RealDimensions Software, LLC
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

using System.Diagnostics.CodeAnalysis;

[assembly:
    SuppressMessage("Microsoft.Design", "CA1050:DeclareTypesInNamespaces", Scope = "type",
        Target = "IconsResourceDictionary",
        Justification = "Have to put this here, since it is appearing in generated file, with no way to override.")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2243:AttributeStringLiteralsShouldParseCorrectly",
        Justification =
            "This was in relation to the Information Version Number generated by GitVersion, which we want to leave as is."
        )]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "ChocolateyGui.Bootstrapper.#GetInstance(System.Type,System.String)",
    Justification = "Not relevant")]
