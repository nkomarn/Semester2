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
    	
    </style>
	</head>
	<body>
		<div>
			<div>
				<?php
					switch (strlen($_GET['vm'])) {
						case 0:
							echo "<h1>Virtual Machine Management</h1>";
							#windows 7
							echo "
							<a href='/?vm=Windows 7'>
								<div>
									<img src='/img/Windows 7.png'>
									<div>
										<h5>Windows 7</h5>
									</div>
								</div>
							</a>
							";
							#windows XP
							echo "
							<a href='/?vm=Windows XP'>
								<div>
									<img src='/img/Windows XP.png'>
									<div>
										<h5>Windows XP</h5>
									</div>
								</div>
							</a>
							";
							#macOS High Sierra
							echo "
							<a href='/?vm=macOS High Sierra'>
								<div>
									<img src='/img/macOS High Sierra.png'>
									<div>
										<h5>macOS High Sierra</h5>
									</div>
								</div>
							</a>
							";
							#windows 95
							echo "
							<a href='/?vm=Windows 95'>
								<div>
									<img src='/img/Windows 95.png'>
									<div>
										<h5>Windows 95</h5>
									</div>
								</div>
							</a>
							";
							break;
						case 'Windows 7':
							
							break;
						case 'Windows XP':
							
							break;
						case 'macOS High Sierra':
							
							break;
						case 'Windows 95':

							break;
						default:
							echo "<h1>Virtual Machine Management</h1>";
							#windows 7
							echo "
							<a href='/?vm=Windows 7'>
								<div>
									<img src='/img/Windows 7.png'>
									<div>
										<h5>Windows 7</h5>
									</div>
								</div>
							</a>
							";
							#windows XP
							echo "
							<a href='/?vm=Windows XP'>
								<div>
									<img src='/img/Windows XP.png'>
									<div>
										<h5>Windows XP</h5>
									</div>
								</div>
							</a>
							";
							#macOS High Sierra
							echo "
							<a href='/?vm=macOS High Sierra'>
								<div>
									<img src='/img/macOS High Sierra.png'>
									<div>
										<h5>macOS High Sierra</h5>
									</div>
								</div>
							</a>
							";
							#windows 95
							echo "
							<a href='/?vm=Windows 95'>
								<div>
									<img src='/img/Windows 95.png'>
									<div>
										<h5>Windows 95</h5>
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
