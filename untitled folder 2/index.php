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
            /* width */
			::-webkit-scrollbar {
    			width: 10px;
			}

			/* Track */
			::-webkit-scrollbar-track {
			    background: #f1f1f1; 
			}

			/* Handle */
			::-webkit-scrollbar-thumb {
			    background: #888; 
			}

			/* Handle on hover */
			::-webkit-scrollbar-thumb:hover {
			    background: #555; 
			}
			/* The Modal (background) */
			.modal {
			    display: none; /* Hidden by default */
			    position: fixed; /* Stay in place */
			    z-index: 1; /* Sit on top */
			    left: 0;
			    top: 0;
			    width: 100%; /* Full width */
			    height: 100%; /* Full height */
			    overflow: auto; /* Enable scroll if needed */
			    background-color: rgb(0,0,0); /* Fallback color */
			    background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
			    padding-top: 60px;
			}

			/* Modal Content/Box */
			.modal-content {
			    background-color: #fefefe;
			    margin: 5px auto; /* 15% from the top and centered */
			    border: 1px solid #888;
			    width: 80%; /* Could be more or less, depending on screen size */
			}

			/* The Close Button */
			.close {
			    /* Position it in the top right corner outside of the modal */
			    position: absolute;
			    right: 25px;
			    top: 0; 
			    color: #000;
			    font-size: 35px;
			    font-weight: bold;
			}

			/* Close button on hover */
			.close:hover,
			.close:focus {
			    color: red;
			    cursor: pointer;
			}

			/* Add Zoom Animation */
			.animate {
			    -webkit-animation: animatezoom 0.6s;
			    animation: animatezoom 0.6s
			}

			@-webkit-keyframes animatezoom {
			    from {-webkit-transform: scale(0)} 
			    to {-webkit-transform: scale(1)}
			}

			@keyframes animatezoom {
			    from {transform: scale(0)} 
			    to {transform: scale(1)}
			}
        </style>
    </head>
    <body>
        
		  <?
		  	if(($_GET[uname] == "username") && ($_GET[psw] == "password")){
		  		echo "<h1>Welcome To Quark Blogs</h1>
        <img class='center' src='thingything.png'/>
		  		<form action="" method='post'>
<textarea name='comments' id='comments' style='width:96%;height:90px;background-color:gold;color:olive;border:none;padding:2%;font:22px/30px sans-serif;'>
Sample Text
</textarea>
<input name='commentButton' type='submit' value='Submit' style='background-color:yellowgreen;color:white;padding:5px;font-size:18px;border:none;padding:8px;'>
</form>";
		  	}
		  	else{
		  		echo "<h1>Welcome To Quark Blogs</h1>
        <img class='center' src='thingything.png'/>
        <!-- Button to open the modal login form -->
		<button class='center' onclick='document.getElementById('id01').style.display='block''>Login</button>

		<!-- The Modal -->
		<div id='id01' class='modal'>
		  <span onclick='document.getElementById('id01').style.display='none'' 
		class='close' title='Close Modal'>&times;</span>

		  <!-- Modal Content -->
		  <form class='modal-content animate' action=''>
		    

		    <div class='container'>
		      <label for='uname'><b>Username</b></label>
		      <input type='text' placeholder='Enter Username' name='uname' required>

		      <label for='psw'><b>Password</b></label>
		      <input type='password' placeholder='Enter Password' name='psw' required>

		      <button type='submit'>Login</button>
		      <label>
		        <input type='checkbox' checked='checked' name='remember'> Remember me
		      </label>
		    </div>

		    <div class='container' style='background-color:#f1f1f1'>
		      <button type='button' onclick='document.getElementById('id01').style.display='none'' class='cancelbtn'>Cancel</button>
		      <span class='psw'>Forgot <a href='#'>password?</a></span>
		    </div>
		  </form>";
		  	}
		  	if(isset($_POST[commentButton]){
		  		echo "<p>" + $_GET[comments] + "</p>";
		  	}
		  ?>
		</div>
    </body>
</html>