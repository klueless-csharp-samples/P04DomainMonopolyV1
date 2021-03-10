DddResourceBuilder.new
  .init
  .resource_key('action:player:pay-super-tax')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
