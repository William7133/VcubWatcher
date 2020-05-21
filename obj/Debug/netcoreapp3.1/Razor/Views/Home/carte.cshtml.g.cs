#pragma checksum "C:\Users\Utilisateur\Documents\VclubWatcher\Views\Home\carte.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a79677c546357aa14be9df1d5a8cf1e13305bb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_carte), @"mvc.1.0.view", @"/Views/Home/carte.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a79677c546357aa14be9df1d5a8cf1e13305bb8", @"/Views/Home/carte.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"105868166e141663c85e5a6cd7765f60e5b54f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_carte : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Utilisateur\Documents\VclubWatcher\Views\Home\carte.cshtml"
  
    ViewData["Title"] = "Carte";
    var data = ViewBag.AllBikeStations;
  

#line default
#line hidden
#nullable disable
            WriteLiteral("  <!DOCTYPE html>\r\n  <html>\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a79677c546357aa14be9df1d5a8cf1e13305bb83445", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <!-- Nous chargeons les fichiers CDN de Leaflet. Le CSS AVANT le JS -->
    <link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.3.1/dist/leaflet.css"" integrity=""sha512-Rksm5RenBEKSKFjgI3a41vrjkw4EVPlJ3+OiI65vTjIdo9brlAacEuKOiQ5OFh7cOI1bkDwLqdLw3Zg0cRJAAQ==""");
                BeginWriteAttribute("crossorigin", " crossorigin=\"", 418, "\"", 432, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
    <link rel=""stylesheet"" type=""text/css"" href=""https://unpkg.com/leaflet.markercluster@1.3.0/dist/MarkerCluster.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""https://unpkg.com/leaflet.markercluster@1.3.0/dist/MarkerCluster.Default.css"" />
    <style type=""text/css"">
      #map { /* la carte DOIT avoir une hauteur sinon elle n'apparaît pas */
        height: 400px;
      }
    </style>
    <title>Carte</title>
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a79677c546357aa14be9df1d5a8cf1e13305bb85335", async() => {
                WriteLiteral(@"
    <div id=""map"">
      <!-- Ici s'affichera la carte -->
    </div>

    <!-- Fichiers Javascript -->
    <script src=""https://unpkg.com/leaflet@1.3.1/dist/leaflet.js"" integrity=""sha512-/Nsx9X4HebavoBvEBuyp3I7od5tA0UzAxs+j83KgC8PU0kgB4XiK4Lfe4y4cgBtaRJQEIFCW+oC506aPT2L1zw==""");
                BeginWriteAttribute("crossorigin", " crossorigin=\"", 1175, "\"", 1189, 0);
                EndWriteAttribute();
                WriteLiteral(@"></script>
    <script type='text/javascript' src='https://unpkg.com/leaflet.markercluster@1.3.0/dist/leaflet.markercluster.js'></script>
    <script type=""text/javascript"">
        // On initialise la latitude et la longitude de Paris (centre de la carte)
        var lat = 48.8534;
        var lon = 2.3488;
        var macarte = null;
        var markerClusters;
        var stations = [];// Servira à stocker les groupes de marqueurs
");
#nullable restore
#line 35 "C:\Users\Utilisateur\Documents\VclubWatcher\Views\Home\carte.cshtml"
         foreach(var station in data)
        {
            

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        stations.push({\r\n            \"name\": \"");
#nullable restore
#line 39 "C:\Users\Utilisateur\Documents\VclubWatcher\Views\Home\carte.cshtml"
                Write(station.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n            \"lat\": \"");
#nullable restore
#line 40 "C:\Users\Utilisateur\Documents\VclubWatcher\Views\Home\carte.cshtml"
               Write(station.lat);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n            \"lon\": \"");
#nullable restore
#line 41 "C:\Users\Utilisateur\Documents\VclubWatcher\Views\Home\carte.cshtml"
               Write(station.lng);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n            \"adresse\" : \"");
#nullable restore
#line 42 "C:\Users\Utilisateur\Documents\VclubWatcher\Views\Home\carte.cshtml"
                    Write(station.address);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n            \"available_bikes\": \"");
#nullable restore
#line 43 "C:\Users\Utilisateur\Documents\VclubWatcher\Views\Home\carte.cshtml"
                           Write(station.available_bikes);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n            \"available_stands\": \"");
#nullable restore
#line 44 "C:\Users\Utilisateur\Documents\VclubWatcher\Views\Home\carte.cshtml"
                            Write(station.available_bike_stands);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n            \"id\" : \"");
#nullable restore
#line 45 "C:\Users\Utilisateur\Documents\VclubWatcher\Views\Home\carte.cshtml"
               Write(station.gid);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n        });\r\n            ");
#nullable restore
#line 47 "C:\Users\Utilisateur\Documents\VclubWatcher\Views\Home\carte.cshtml"
                   
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        // Fonction d'initialisation de la carte
        function initMap() {
            var markers = []; // Nous initialisons la liste des marqueurs
	// Nous définissons le dossier qui contiendra les marqueurs
	var iconBase = 'http://localhost/carte/icons/';
	// Créer l'objet ""macarte"" et l'insèrer dans l'élément HTML qui a l'ID ""map""
	macarte = L.map('map').setView([lat, lon], 11);
	markerClusters = L.markerClusterGroup(); // Nous initialisons les groupes de marqueurs
	// Leaflet ne récupère pas les cartes (tiles) sur un serveur par défaut. Nous devons lui préciser où nous souhaitons les récupérer. Ici, openstreetmap.fr
	L.tileLayer('https://{s}.tile.openstreetmap.fr/osmfr/{z}/{x}/{y}.png', {
		// Il est toujours bien de laisser le lien vers la source des données
		attribution: 'données © OpenStreetMap/ODbL - rendu OSM France',
		minZoom: 1,
		maxZoom: 20
    }).addTo(macarte);
	// Nous parcourons la liste des villes
	for (station in stations) {
		// Nous définissons l'icône à utiliser");
                WriteLiteral(@" pour le marqueur, sa taille affichée (iconSize), sa position (iconAnchor) et le décalage de son ancrage (popupAnchor)
        var myIcon = L.icon({
            iconUrl: 'https://' + window.location.host + ""/img/marker.png"",
			iconSize: [50, 50],
			iconAnchor: [25, 50],
			popupAnchor: [-3, -76],
        });
		var marker = L.marker([stations[station].lat, stations[station].lon], { icon: myIcon }); // pas de addTo(macarte), l'affichage sera géré par la bibliothèque des clusters
        marker.bindPopup(stations[station].name + '<br>Velovs disponibles : ' + stations[station].available_bikes + '<br>Places disponibles : ' + stations[station].available_stands + '<br><a class=""btn btn-danger"" href='+window.location.origin+'/Carte/AddStationToFav/'+stations[station].id+'>Ajouter aux favoris</a>');
		markerClusters.addLayer(marker); // Nous ajoutons le marqueur aux groupes
        markers.push(marker); // Nous ajoutons le marqueur à la liste des marqueurs
	}
        var group = new L.featureGroup(marker");
                WriteLiteral(@"s); // Nous créons le groupe des marqueurs pour adapter le zoom
	    //macarte.fitBounds(group.getBounds().pad(0.5)); // Nous demandons à ce que tous les marqueurs soient visibles, et ajoutons un padding (pad(0.5)) pour que les marqueurs ne soient pas coupés
	    macarte.addLayer(markerClusters);
    }
        window.onload = function () {
            //Fonction d'initialisation qui s'exécute lorsque le DOM est chargé
            if (""geolocation"" in navigator) {
                navigator.geolocation.getCurrentPosition(function (position) {
                    lat = position.coords.latitude;
                    lon = position.coords.longitude;
                    initMap();
                }, () => { initMap(); });
            }
        };
    </script>
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
