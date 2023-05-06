<?php 
	function deltaArray($num,$array){
		$output = array_map(function($element) use ($num){
			return $element * $num;	
		},$array);

		return $output;
	}


	print_r(deltaArray(2 ,[1, 2, 3 ]));


	print_r(deltaArray(3 ,[1, 2, 3 ]));


        print_r(deltaArray(4 ,[1, 2, 3 ]));



?>
