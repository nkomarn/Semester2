<!DOCTYPE html>
<html>
    <head>
        <title>Quark Blogs</title>
        <link href="https://fonts.googleapis.com/css?family=Jua" rel="stylesheet">
          
    


        <style type="text/css">
            h1{
                font-family: 'Jua', sans-serif;
                color: blueviolet;
                box-shadow: 0px 2px 4px aqua;
                text-align: center;
                font-size: 50px;
            }
            body{
            	background-color: black;
            }
            .center{
                display: block;
                margin-left: auto;
                margin-right: auto;
            }
            .alltexts{
                font-family: 'Jua', sans-serif;
                color: white;
                 text-align: center;
                font-size: 36px;
            }
            .white{
                font-family: 'Jua', sans-serif;
                color: white;
            }
            
           
        </style>
    </head>
    <body>
         <h1>Welcome To Quark Blogs</h1>
        <img class='center' src='thingything.png'/>
        
		 
         
		  
	    <form class='white' action="" method='post'>
            Comments: <textarea  rows="10" cols="30" name="commentContent"></textarea><br/>
                Name: <input type="text" name="name"><br/>
                <input type="submit" value="Post!"><br/>
            </form>
           
		  	 <?php
        if($_POST){
            $name = $_POST['name'];
            $content = $_POST['commentContent'];
            echo "<p class='center'> <div class= 'alltexts'>" . $name . "</div><div class='alltexts'>" . $content .  "</div></p>";
        }
        ?>
		
    </body>
</html>