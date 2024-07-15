font-face {
  font-family: "poppins-regular";
  src: url("../poppins/Poppins-Regular.ttf");
  font-family: "poppins-bold";
  src: url("../poppins/Poppins-Bold.ttf");
}

footer .rosa {
  font-family: "poppins-regular", sans-serif;
  color: rgb(226, 43, 110);
  font-size: smaller;
  text-align: center;
  margin: 10px;
  padding: 20px;
  box-sizing: content-box;
}

header .navbar .logo {
  vertical-align: middle;
}
header header nav,
header li {
  display: inline-block;
  margin-right: 10px;
}

* {
  padding: 20;
  margin: 20;
  box-sizing: content-box;
}

h1 {
  font-family: "poppins-bold", sans-serif;
  font-size: large;
  color: rgb(226, 43, 110);
  margin: 20;
  padding: 20;
  text-align: center;
}

h2 {
  font-family: "poppins-bold", sans-serif;
  font-size: medium;
  color: rgb(226, 43, 110);
  margin: 20;
  padding: 20;
  text-align: center;
}

h3 {
  font-family: "poppins-regular", sans-serif;
  font-size: medium;
  margin: 20;
  padding: 20;
  text-align: center;
}

p {
  font-family: "poppins-regular", sans-serif;
  font-size: small;
  text-align: left;
  margin: 20;
  padding: 20;
}

ul li a {
  list-style: none;
  display: inline-block;
  font-family: "poppins-regular", sans-serif;
  font-size: smaller;
  text-decoration: none;
  list-style: none;
}

main section .grids3 {
  display: grid;
  grid-template-columns: 1fr 1fr;
  grid-template-rows: 300px 400px;
  grid-template-areas: "imagencontacto imagencontacto" "whatsapp ubicacion";
}
main .imagencontacto {
  grid-area: imagencontacto;
  margin: 10;
  padding: 40;
  width: 25%;
  height: 25%;
  box-sizing: content-box;
  text-align: center;
}
main .whatsapp {
  grid-area: whatsapp;
  font-size: medium;
  background-color: rgb(226, 43, 110);
  text-align: left;
}
main .ubicacion {
  grid-area: ubicacion;
  font-size: medium;
  background-color: rgb(226, 43, 110);
  text-align: left;
}

main .textoinicio, main .tituloindex {
  text-align: center;
  margin: 10px;
  padding: 30px;
  box-sizing: content-box;
}
main .fotoinicio {
  width: 100%;
  text-align: center;
}

main .grids4 {
  display: grid;
  grid-template-columns: 1fr 1fr;
  grid-template-rows: 600px 200px;
  grid-template-areas: "cami sofi" "sobrenosotras sobrenosotras";
}
main .cami {
  grid-area: cami;
}
main .sofi {
  grid-area: sofi;
}
main p .sobrenosotras {
  grid-area: sobrenosotras;
  margin: 20;
  padding: 20;
  font-family: "poppins-regular", sans-serif;
  color: rgb(226, 43, 110);
}

main .grids {
  display: grid;
  grid-template-columns: 1fr 1fr;
  grid-template-rows: 100px 100px 600px 1fr 1fr;
  grid-template-areas: "tituloprincipal.tituloprincipal" "titulofondo titulofondo2" "logo1 logo2" "logo3 logo3" "logo4 logo4";
}
main .tituloprincipal {
  grid-area: tituloprincipal;
}
main .titulofondo {
  grid-area: titulofondo;
}
main .titulofondo2 {
  grid-area: titulofondo2;
}
main .imagen1 {
  grid-area: logo1;
}
main .imagen2 {
  grid-area: logo2;
}
main .imagen3 {
  grid-area: logo3;
}
main .imagen4 {
  grid-area: logo4;
}
main .grids img {
  width: 75%;
  height: 75%;
  object-fit: contain;
  text-align: center;
}
main .titulofondo:hover,
main .titulofondo2:hover {
  color: lightslategray;
}

main .grids1 {
  display: grid;
  grid-template-columns: 1fr 1fr 1fr;
  grid-template-rows: 100px 500px;
  grid-template-areas: "tituloservicios tituloservicios tituloservicios" "tarjeta1 tarjeta2 tarjeta3";
}
main .tituloservicios {
  grid-area: tituloservicios;
  grid-column: 2/3;
}
main .tarjeta1 {
  grid-area: tarjeta1;
}
main .tarjeta2 {
  grid-area: tarjeta2;
}
main .tarjeta3 {
  grid-area: tarjeta3;
}
main .tarjeta1, main .tarjeta2, main .tarjeta3 {
  background-image: linear-gradient to right, #bbd6fb, #f6aaf2;
  padding: 10px;
  margin: 20px;
  width: 400px;
  height: 300px;
  box-sizing: content-box;
  text-align: left;
}

.tarjeta1:hover, .tarjeta2:hover, .tarjeta3:hover {
  color: lightslategray;
}

/*# sourceMappingURL=styles.cs.map */
