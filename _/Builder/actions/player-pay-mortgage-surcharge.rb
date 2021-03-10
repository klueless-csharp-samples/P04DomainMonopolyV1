DddResourceBuilder.new
  .init
  .resource_key('action:player:pay-mortgage-surcharge')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
