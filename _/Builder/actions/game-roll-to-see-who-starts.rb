DddResourceBuilder.new
  .init
  .resource_key('action:game:roll-to-see-who-starts')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
