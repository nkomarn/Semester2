<!DOCTYPE html>
<html>
	<head>
		<title>Virtual Machine Command</title>
		   <!-- Import Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous">
    
    <!-- Import Bootstrap Javascript -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.0/umd/popper.min.js" integrity="sha384-cs/chFZiN24E4KMATLdqdvsezGxaGsi4hLGOzlXwp5UZB1LY//20VyM2taTB4QvJ" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/js/bootstrap.min.js" integrity="sha384-uefMccjFJAIv6A+rW+L4AHf99KvxDjWSu1z9VI8SKNVmz4sk7buKt/6v9KI65qnm" crossorigin="anonymous"></script>


    <style type="text/css">
    	<link href="https://fonts.googleapis.com/css?family=Indie+Flower" rel="stylesheet"> 
    	.text-card{
    		font-family: 'Indie Flower', cursive;
    		color: black;
    	}
    	.image-card{
    		height: 100px;
    		width: 150px;
    		margin: 2px;
    		border: 1px;
    		border-radius: 3px;
    		overflow: hidden;
    		box-shadow: 0px 5px 15px rgb(209, 224, 224);
    		transition: box-shadow 5s ease, transform 5s ease;

    	}
    	.image-card:hover{
    		box-shadow: 5px 10px 20px rgb(209, 224, 224);
    	}
    	.input-start{
    		font-family: 'Indie Flower', cursive;
    		color: green;
    		box-shadow: 0px 2px 6px green;
    		transition: box-shadow 5s ease, transform 5s ease;
    	}
    	.input-start:hover{
    		box-shadow: 2px 4px 12px green;
    	}
    	.input-start:active{
    		color: black;
    		box-shadow: 0px 2px 6px black;
    	}

    	.input-shutdown{
    		font-family: 'Indie Flower', cursive;
    		color: red;
    		box-shadow: 0px 2px 6px red;
    		transition: box-shadow 5s ease, transform 5s ease;
    	}
    	.input-shutdown:hover{
    		box-shadow: 2px 4px 12px red;
    	}
    	.input-shutdown:active{
    		color: black;
    		box-shadow: 0px 2px 6px black;
    	}

    	.input-restart{
    		font-family: 'Indie Flower', cursive;
    		color: yellow;
    		box-shadow: 0px 2px 6px yellow;
    		transition: box-shadow 5s ease, transform 5s ease;
    	}
    	.input-restart:hover{
    		box-shadow: 2px 4px 12px yellow;
    	}
    	.input-restart:active{
    		color: black;
    		box-shadow: 0px 2px 6px black;
    	}

    	.input-reset{
    		font-family: 'Indie Flower', cursive;
    		color: blue;
    		box-shadow: 0px 2px 6px blue;
    		transition: box-shadow 5s ease, transform 5s ease;
    	}
    	.input-reset:hover{
    		box-shadow: 2px 4px 12px blue;
    	}
    	.input-reset:active{
    		color: black;
    		box-shadow: 0px 2px 6px black;
    	}
    </style>
	</head>
	<body>
		<div>
			<div>
				<?php
					
					switch ($_GET["vm"]) {
						case "":
							echo "<h1>Virtual Machine Management</h1>";
							#windows 7
							echo "
							<a href='/?vm=Windows 7'>
								<div>
									<img class='image-card' src='/img/Windows 7.png'>
									<div>
										<h5 class='text-card'>Windows 7</h5>
									</div>
								</div>
							</a>
							";
							#windows XP
							echo "
							<a href='/?vm=Windows XP'>
								<div>
									<img class='image-card' src='/img/Windows XP.png'>
									<div>
										<h5 class='text-card'>Windows XP</h5>
									</div>
								</div>
							</a>
							";
							#macOS High Sierra
							echo "
							<a href='/?vm=macOS High Sierra'>
								<div>
									<img class='image-card' src='/img/macOS High Sierra.png'>
									<div>
										<h5 class='text-card'>macOS High Sierra</h5>
									</div>
								</div>
							</a>
							";
							#windows 95
							echo "
							<a href='/?vm=Windows 95'>
								<div>
									<img class='image-card' src='/img/Windows 95.png'>
									<div>
										<h5 class='text-card'>Windows 95</h5>
									</div>
								</div>
							</a>
							";
							break;
						case "Windows 7":
							echo "<h1>Welcome to Windows 7</h1>";
							echo "
							<form action='' method='POST'>
								<input type='submit' name='button-start'>Start</input>
								<input type='submit' name='button-shutdown'>Shutdown</input>
								<input type='submit' name='button-restart'>Restart</input>
								<input type='submit' name='button-restart'>Reset</input>
							</form>
							";
							if(null !== ($_POST('button-start'))){
								$output = shell_exec('VBoxManage startvm "Windows 7"');
                            	echo "<pre>$output</pre>";
							}
							break;
						case "Windows XP":
							
							break;
						case "macOS High Sierra":
							
							break;
						case "Windows 95"
						:
							break;
						default:
							echo "<h1>Virtual Machine Management</h1>";
							#windows 7
							echo "
							<a href='/?vm=Windows 7'>
								<div>
									<img class='image-card' src='/img/Windows 7.png'>
									<div>
										<h5 class='text-card'>Windows 7</h5>
									</div>
								</div>
							</a>
							";
							#windows XP
							echo "
							<a href='/?vm=Windows XP'>
								<div>
									<img class='image-card' src='/img/Windows XP.png'>
									<div>
										<h5 class='text-card'>Windows XP</h5>
									</div>
								</div>
							</a>
							";
							#macOS High Sierra
							echo "
							<a href='/?vm=macOS High Sierra'>
								<div>
									<img class='image-card' src='/img/macOS High Sierra.png'>
									<div>
										<h5 class='text-card'>macOS High Sierra</h5>
									</div>
								</div>
							</a>
							";
							#windows 95
							echo "
							<a href='/?vm=Windows 95'>
								<div>
									<img class='image-card' src='/img/Windows 95.png'>
									<div>
										<h5 class='text-card'>Windows 95</h5>
									</div>
								</div>
							</a>
							";
							break;
					}
				
				?>
			</div>
		</div>









	</body>
</html>
