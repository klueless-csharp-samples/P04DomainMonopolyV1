DddResourceBuilder.new
  .init
  .resource_key('action:card:take-card')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
