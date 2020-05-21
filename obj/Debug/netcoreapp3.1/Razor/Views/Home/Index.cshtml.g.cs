#pragma checksum "C:\Users\Utilisateur\Documents\VclubWatcher\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5560a5ab011783f8db0fedd3850e57b2048b321"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Utilisateur\Documents\VclubWatcher\Views\_ViewImports.cshtml"
using VclubWatcher;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Utilisateur\Documents\VclubWatcher\Views\_ViewImports.cshtml"
using VclubWatcher.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5560a5ab011783f8db0fedd3850e57b2048b321", @"/Views/Home/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"105868166e141663c85e5a6cd7765f60e5b54f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Utilisateur\Documents\VclubWatcher\Views\Home\index.cshtml"
  
  ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
  <h1 class=""display-4"">Liste</h1>
</div>
<h2>William Fernandes</h2>
<ul class=""list-group"">
  <li class=""list-group-item disabled"" aria-disabled=""true"">
   1. Avoir une application ASP.Net Core de base nommée ""VCubWatcher"" qui tourne sur sa machine
    Démarrer un site avec asp dotnet core :  https://docs.microsoft.com/fr-fr/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-3.1&tabs=visual-studio
  </li>
 
  <li class=""list-group-item disabled"" aria-disabled=""true"">
    2. Créer un repository public sur github, bitbucket ou gitlab pour héberger votre code.
    gitignore de base pour .NET Core :  https://gist.github.com/vmandic/ac2ecc9c24f6899ee0ec46e4ce444a0e.
  </li>

  <li class=""list-group-item disabled"" aria-disabled=""true"">3. Publier votre code sur le repository à chaque avancée (attention, si l'historique ne présente pas les commits au fur et à mesure de votre avancée, cela pourra être pénalisé)</li>

  <li class=""list-group-item disabled"" aria-dis");
            WriteLiteral(@"abled=""true"">4. Supprimer du menu les pages de bases pour 2 liens de menu fonctionnels vers les pages vides suivantes : ""Accueil"", ""Liste des stations"", ""Carte"", ""Mes favoris""</li>

  <li class=""list-group-item disabled"" aria-disabled=""true"">5. Compléter la pages ""Accueil"" pour présenter votre travail, votre nom/prenom, cette liste d'objectifs (que vous rayerez au fur et à mesure qu'ils sont complétés) et l'URL où votre code source est visible</li>

  <li class=""list-group-item"">
    6. Se brancher sur l'API Vcub de Bordeaux Métropole pour récupérer les données en temps réel
    API avec des données simples à exploiter 🙂 https://api.alexandredubois.com/vcub-backend/vcub.php
    Passer des données à la vue :  https://docs.microsoft.com/fr-fr/aspnet/core/mvc/views/overview?view=aspnetcore-3.1
    Générer des classes C# à partir d'un flux JSON :  http://json2csharp.com/
    Lire des données issues d'un flux JSON :  https://docs.microsoft.com/fr-fr/dotnet/csharp/tutorials/console-webapiclientr
  </li>

");
            WriteLiteral(@"  <li class=""list-group-item"">
    7. Afficher les données de l'API sous forme de tableau sur la page ""Liste des stations"" (les stations sont triées par ordre alphabétique). Pour chaque station on affichera : la commune, le nom de la station, le nombre de vélo électriques, le nombre de vélos au total, ainsi que le nombre d'emplacements libres.
    Razor Cheat sheet : https://gist.github.com/jonlabelle/8738373t
  </li>

  <li class=""list-group-item"">
    8. fficher les données de l'API sous forme de carte sur la page ""Carte"" (chaque station sera représentée par une épingle à son emplacement)
    Intégrer une carte openstreet map sur un site : https://nouvelle-techno.fr/actualites/2018/05/11/pas-a-pas-inserer-une-carte-openstreetmap-sur-votre-site)
  </li>

  <li class=""list-group-item"">9. Ajouter sur chaque épingle de la carte la possibilité de cliquer pour afficher une infobulle qui indiquera le nombre de vélos disponibles et de places libres à la station en question</li>

  <li class=""list-group-ite");
            WriteLiteral(@"m"">10. Ajouter sur la page ""Liste des stations"" et/ou ""Carte"" la possibilité de rajouter des stations en favoris</li>

  <li class=""list-group-item"">11. Compléter la page ""Mes favoris"" pour n'afficher sous forme de tableau que les stations marquées en favoris</li>
  <li class=""list-group-item"">
   12. Stocker les stations favorites dans une base SQL
    Prise en main d'EF Core dans une application web MVC ASP.Net https://docs.microsoft.com/fr-fr/aspnet/core/data/ef-mvc/intro?view=aspnetcore-3.1n
  </li>

  <li class=""list-group-item"">
   13. Centrer automatiquement la carte par rapport à la position de l'utilisateur
    Récupérer la position de l'utilisateur : https://developer.mozilla.org/fr/docs/Web/API/Geolocation_API
  </li>

  <li class=""list-group-item"">14. Trier automatiquement la liste des stations par rapport à la position de l'utilisateur</li>

  <li class=""list-group-item"">
    15. Rendre votre application bilingue Français / Anglais
    https://docs.microsoft.com/fr-fr/aspnet/core/fun");
            WriteLiteral(@"damentals/localization?view=aspnetcore-3.1s
  </li>

  <li class=""list-group-item"">
   16. Déployer votre code sur un serveur accessible publiquement en consultation
    Déployer une application ASP.Net Core sur un serveur Debian : https://medium.com/setu677/how-to-host-asp-net-core-on-linux-using-nginx-85339560e929
    Déployer une application ASP.Net Core sur Azure : https://docs.microsoft.com/fr-fr/aspnet/core/tutorials/publish-to-azure-webapp-using-vs?view=aspnetcore-3.1L
  </li>

  <li class=""list-group-item"">17. Faire en sorte que votre site soit agréable à utiliser sur mobile (il ne doit pas comporter ascenseur horizontal)</li>

  <li class=""list-group-item"">18. BONUS : toute fonctionnalité supplémentaire sera valorisée, pensez-juste à l'indiquer sur votre page d'accueil que je puisse la comptabiliser</li>
  
</ul>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
