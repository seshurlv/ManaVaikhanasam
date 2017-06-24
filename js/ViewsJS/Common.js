var menuHeader = `
<nav class='navbar navbar__mod'>	
	<div class='navbar-brand'><a href='index.html'><h1 class='brand_name'>Mana Vaikhanasam</h1></a></div>
	<ul class='nav sf-menu' data-type='navbar'>
		<li id='liHome'><a href='index.html'>Home</a></li>
		<li id='liSVMM'><a class='dropdown' href='#'>SVMM</a>
			<ul>
				<li><a href='SVMM.html'>Sri Vaikhanasa Maha Mandali </a></li>
				<li><a href='SVMM_WorkingComittee.html'>Working Committe </a></li>                            
			</ul>
		</li>
		<li id='liAshramam'><a class='dropdown' href='#'>Ashramam</a>
			<ul>
				<li><a href='ashramam.html'>Vaikhanasa Ashramam @ Hyderabad</a></li>                                                        
				<li><a href='ashramam-donors.html'>Donors for Ashramam</a></li>				
			</ul>
		</li>
		<li id='liGallery'><a class='dropdown' href='#'>Gallery</a>
			<ul>
				<li><a href='Gallery.html'>Photos</a></li>
				<li><a href='mv_Videos.html'>Videos</a></li>                            
			</ul>
		</li>
		<li id='liServices'><a class='dropdown' href='#'>Services</a>
			<ul>
				<li><a href='directory.html'>Vaikhanasa Directory</a></li>
				<li><a href='Vaikhanasa_Matrimony.html'>Vaikhanasa Matrimony</a></li>
				<li><a href='Vaikhanasa_Purohitulu.html'>Vaikhanasa Purohitulu</a></li>
			</ul>
		</li> 
		<li id='liDownloads'><a class='dropdown' href='#'>Downloads</a>
			<ul>
				<li><a href='Documents.html'>Documents</a></li>
				<li><a href='Pravachanamulu.html'>Pravachanamulu</a></li>
				<li><a href='Asthotharamulu.html'>Asthotharamulu</a></li>
				<li><a href='Keerthanalu.html'>Keerthanalu</a></li>
				<li><a href='Books.html'>Books</a></li>				
				<li><a href='Stories.html'>Stories</a></li>
			</ul>
		</li>
		<li id='liNews'><a href='news.html'>News</a></li>
		<li id='liContacts'><a href='contact.html'>Contact</a></li>
	</ul>
</nav>
`;

var menuFooter = `
	<section class="well7 bg-primary">
        <div class="container" id='menuFooter'>
		    <div class='col-md-12 col-sm-12 wow fadeInUp' data-wow-duration='2s' data-wow-delay='0.8s'>
		        <h4 class='clr-primary fw-b paddingBottom20'>Get in touch</h4>
		        <div><img class='GetInTouchImage' src='images\\mysite\\users\\seshu.jpg'/></div>
		        <div class='contact-list2 paddingLeft20'>
		            <dl>
		            	<dt>Phone:</dt>
		                <dd><a href='callto:#'> +91 995 993 3822</a></dd>                                
		            </dl>
		            <dl>
		                <dt>E-mail:</dt>
		                <dd><a class='fw3' href='mailto:#'>seshu.manavaikhanasam@gmail.com</a></dd>
		            </dl>
		        </div>
		    </div>                    
		</div>
	</section>
	<div class="container">
        <p class="copyright">
             &#169; <span id="copyright-year"></span> <span class="ttu">Mana Vaikhanasam.</span>
            Designed and Developed By RLV Seshu Kumar. All rights reserved. <a href="index-5.html">Privacy Policy</a>
            <!-- {%FOOTER_LINK} -->
        </p>
    </div>
`;

function drawTable(data, tableId) {
    for (var i = 0; i < data.length; i++) {
        drawRow(data[i], tableId);
    }
}

function drawRow(rowData, tableId) {
    var row = $("<tr />")
    $(tableId).append(row); //this will append tr element to table... keep its reference for a while since we will add cels into it
    row.append($("<td>" + rowData.SNO + "</td>"));
    row.append($("<td>" + rowData.NAME + "</td>"));
    row.append($("<td>" + rowData.PLACE + "</td>"));
    row.append($("<td>" + rowData.AMOUNT + "</td>"));
}