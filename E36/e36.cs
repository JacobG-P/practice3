Header {
  background-color: #f2f2f2;
  padding: 20px;
  display: flex;
  justify-content: center;
  align-items: center;
}
nav ul {
  list-style-type: none;
  display: flex;
  justify-content: center;
  align-items: center;
}

nav ul li {
  margin-right: 50px;
  border-radius: 30px;
  animation: animate-tiles 2s alternate infinite;
}

nav ul li:hover {
  transform:scale(1.2, 1.2);
  opacity: 2;
  z-index: 2;
}
body {
  font-family: Arial, sans-serif;
  margin: 0;
  padding: 0;
}
h1 {
  margin: 0;
}    

/* Style for the button */
    .turbo-gauge-dropdown {
      display: inline-block;
      position: relative;
      cursor: pointer;
      margin-bottom: 10px;
    }

    /* Style for the dropdown content */
    .turbo-gauges {
      display: none;
      position: absolute;
      z-index: 1;
    }
    /* Show the dropdown content when the button is clicked */
    .turbo-gauge-dropdown:hover .turbo-gauges {
      display: block;
    }
.gear-stick-dropdown {
      display: inline-block;
      position: relative;
      cursor: pointer;
      margin-bottom: 10px;
    }

    /* Style for the dropdown content */
    .gear-sticks{
      display: none;
      position: absolute;
      z-index: 1;
    }
    /* Show the dropdown content when the button is clicked */
    .gear-stick-dropdown:hover .gear-sticks {
      display: block;
    }
.cover-dropdown {
      display: inline-block;
      position: relative;
      cursor: pointer;
      margin-bottom: 10px;
    }

    /* Style for the dropdown content */
    .covers {
      display: none;
      position: absolute;
      z-index: 1;
    }
    /* Show the dropdown content when the button is clicked */
    .cover-dropdown:hover .covers {
      display: block;
    }
.holder-dropdown {
      display: inline-block;
      position: relative;
      cursor: pointer;
      margin-bottom: 10px;
    }

    /* Style for the dropdown content */
    .holders {
      display: none;
      position: absolute;
      z-index: 1;
    }
    /* Show the dropdown content when the button is clicked */
    .holder-dropdown:hover .holders {
      display: block;
    }
    .random-dropdown {
      display: inline-block;
      position: relative;
      cursor: pointer;
      margin-bottom: 10px;
    }

    /* Style for the dropdown content */
    .randoms {
      display: none;
      position: absolute;
      z-index: 1;
    }
    /* Show the dropdown content when the button is clicked */
    .random-dropdown:hover .randoms {
      display: block;
    }

.products{
  display: flex;
  justify-content: center;
  align-items: center;
  margin-top: 100px;
  margin-bottom: 5%;
  height: 10vh;
  width: 100vw;
}