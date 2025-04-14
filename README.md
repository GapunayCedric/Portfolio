<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Portfolio</title>
    <link rel="stylesheet" href="styles.css">
    <style>
        * {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: Arial, sans-serif;
}

body {
    background-color: #121212;
    color: white;
}

header {
    background-color: #1a1a1a;
    padding: 15px 50px;
}

nav {
    display: flex;
    justify-content: space-between;
    align-items: center;
}

.logo {
    font-size: 20px;
    font-weight: bold;
}

.nav-links {
    list-style: none;
    display: flex;
}

.nav-links li {
    margin: 0 15px;
}

.nav-links a {
    text-decoration: none;
    color: white;
    transition: 0.3s;
}

.nav-links a:hover {
    color: #bbbbbb;
}

.menu-icon {
    display: none;
    font-size: 24px;
    cursor: pointer;
}

.hero {
    display: flex;
    height: 90vh;
}

.hero-left, .hero-right {
    width: 50%;
}

.hero-left img {
    width: 100%;
    height: 100%;
    object-fit: cover;
}

.hero-right {
    display: flex;
    flex-direction: column;
    justify-content: center;
    padding: 50px;
    background-color: #181818;
}

.hero-right h1 {
    font-size: 50px;
}

.hero-right .highlight {
    font-weight: bold;
    color: white;
}

.hero-right p {
    font-size: 16px;
    margin: 10px 0;
}

.btn {
    display: inline-block;
    padding: 10px 20px;
    margin-top: 20px;
    background: white;
    color: black;
    text-decoration: none;
    font-weight: bold;
    border-radius: 5px;
}

.btn:hover {
    background: #dddddd;
}

/* Responsive Design */
@media (max-width: 768px) {
    .hero {
        flex-direction: column;
    }

    .hero-left, .hero-right {
        width: 100%;
        text-align: center;
    }

    .hero-right {
        padding: 30px;
    }

    .nav-links {
        display: none;
    }

    .menu-icon {
        display: block;
    }
}


    </style>
</head>
<body>
    <header>
       
        <nav>
            <div class="logo">Cedric Gapunay</div>
            <ul class="nav-links">
                <li><a href="#">Home</a></li>

                <a href="motto.html">Motto</a>

                <a href="about.html">About Me</a>

                <a href="contact.html">Contact</a>
            

            </ul>
            <div class="menu-icon">&#9776;</div>     
        </nav>
    
    </header>

    <section class="hero">
        <div class="hero-left">
            <img src="image.png" alt="Profile Image" width="300">
        </div>
        <div class="hero-right">
            <h1>My <br><span class="highlight">Portfolio</span></h1>
            <p>Web designer / graphic designer</p>
            <a href="#" class="btn">Explore More</a>
        </div>
    </section>
</body>
</html>
